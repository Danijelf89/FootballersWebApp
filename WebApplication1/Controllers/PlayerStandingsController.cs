using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("playerStandings")]
    public class PlayerStandingsController : Controller
    {
        private DataContext context;
        private int defaultPos = 1;

        public PlayerStandingsController(DataContext con)
        {
            if (context == null)
            {
                context = con;
            }
        }

        private DataContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }

        [HttpGet("GetPlayers")]
        public List<PlayerHistoricalStandings> GetClubs()
        {
            return Context.PlayersStandings.OrderBy(x => x.Standing).ToList();
        }

     

        [HttpPost("AddNewGame")]
        public void AddNewGame(List<Players> players)
        {

            List<PlayerHistoricalStandings> dbData = Context.PlayersStandings.ToList();

            foreach (Players player in players)
            {

                PlayerHistoricalStandings existing = dbData.FirstOrDefault(x => x.Name == player.Name && x.Surname == player.Surname);

                if(existing != null)
                {
                    existing.Points = player.Points;
                    context.PlayersStandings.Update(existing);
                    context.SaveChanges();
                }

                else
                {
                    PlayerHistoricalStandings newPlayer = new PlayerHistoricalStandings();
                    newPlayer.Name = player.Name;
                            newPlayer.Surname = player.Surname;
                            newPlayer.Points = player.Points;
                            context.PlayersStandings.Add(newPlayer);
                            context.SaveChanges();
                }
            }

            foreach (PlayerHistoricalStandings model in Context.PlayersStandings.ToList().OrderByDescending(x => x.Points))
            {
               
                model.Standing = defaultPos;
                defaultPos++;
                context.PlayersStandings.Update(model);
                context.SaveChanges();
            }
           
        }
        
    }
}

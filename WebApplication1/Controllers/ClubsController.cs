using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("clubs")]
    public class ClubsController : Controller
    {
        private DataContext context;

        public ClubsController(DataContext con)
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

        [HttpGet("GetClubs")]
        public List<Club> GetClubs()
        {
            return Context.Club.ToList();
        }

        [HttpDelete("DeleteClub/{id:int}")]
        public void DeleteClub(int id)
        {
            try
            {
                Club club = context.Club.FirstOrDefault(x => x.Id == id);
                List<Footballer> referncedFootballers = context.Footballer.Where(x => x.ClubId == club.Id).ToList();

                context.Club.Remove(club);
                context.SaveChanges();

                if(club.ClubName != "-")
                {
                    foreach(Footballer fo in referncedFootballers)
                    {
                        fo.ClubId = context.Club.Where(x => x.ClubName == "-").Select(x => x.Id).FirstOrDefault();
                    }

                    context.Footballer.UpdateRange(referncedFootballers);
                     context.SaveChanges();
                }
            }
            catch (InvalidOperationException ex)
            {
               
                throw ex;
            }
        }

        [HttpPost("AddNewClub")]
        public void AddNewClub(Club club)
        {
            try
            {
                context.Club.Add(club);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        [HttpPut("UpdateClub")]
        public void UpdateClub(Club club)
        {
            try
            {
                context.Club.Update(club);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}

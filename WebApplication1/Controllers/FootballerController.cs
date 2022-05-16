using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.Properties;

namespace WebApplication1.Controllers
{
    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("footballer")]
    public class FootballerController : ControllerBase
    {
        public JavaScriptSerializer serializer = new JavaScriptSerializer();
        private DataContext context;

        public FootballerController(DataContext con)
        {
            if(context == null)
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


        [HttpGet("Getfootballers")]
        public List<Footballer> Getfootballers()
        {
             try
              {
                foreach (Footballer fo in Context.Footballer.ToList())
                 {
                   if(fo.ClubId != 0)
                    {
                      fo.Club = Context.Club.FirstOrDefault(x => x.Id == fo.ClubId);
                    }
                 }

                return Context.Footballer.ToList();

             }

             catch (Exception e)
             {
                  throw e;
             }           
        }

        [HttpDelete("DeleteFootballer/{id:int}")]
        public void DeleteFootballer(int id)
        {
            try
            {
                Footballer fot = Context.Footballer.FirstOrDefault(x => x.Id == id);

                if (fot != null)
                {
                    Context.Footballer.Remove(fot);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        [HttpPost("AddNewFootballer")]
        public void AddNewFootballer(Footballer footballer)
        {
            try
            {
                footballer.Status = GetStatus(footballer);

                footballer.Club = null;
                context.Footballer.Add(footballer);
                context.SaveChanges();

            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }


       [HttpPut("UpdateFootballer")]
       public void UpdateFootballer(Footballer footbaler)
        {
            try
            { 
                footbaler.Status = GetStatus(footbaler);
                
                context.Footballer.Update(footbaler);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private string GetStatus(Footballer fo)
        {
            if (fo.Club.IsDefault)
            {
               return Resources.FOOTBALLER_STATUS_FREE_AGENT;
            }
           
         return Resources.FOOTBALLER_STATUS_UNDER_CONTRACT;
            
        }
    }
}

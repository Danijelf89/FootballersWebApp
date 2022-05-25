using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {
        }

        public DbSet<Footballer> Footballer { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //foreach(var foregnKey in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            //{
            //    foregnKey.DeleteBehavior = DeleteBehavior.NoAction;
                
            //}
       
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sports.Models
{
    public class SportsContext : DbContext
    {
        public virtual DbSet<Division> Divisions { get; set;  }
        public virtual DbSet<Team> Teams { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Sports;integrated security=True"); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class Connections:DbContext      
    {
        public Connections (DbContextOptions<Connections> options):base(options)
        {

        }

        public DbSet<Money> Moneyd { get; set; }
        public DbSet<Goods> Goodsd { get; set; }
        public DbSet<Disaster> Disasterd { get; set; }

    }
}

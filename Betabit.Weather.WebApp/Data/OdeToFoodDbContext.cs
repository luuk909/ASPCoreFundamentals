using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Betabit.Weather.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Betabit.Weather.WebApp.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

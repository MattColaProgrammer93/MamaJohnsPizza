using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaJohn_sPizza
{
    public class PizzaOrderContext : DbContext
    {
        public PizzaOrderContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MamaJohnsPizzaStorage;Trusted_Connection=True;");
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}

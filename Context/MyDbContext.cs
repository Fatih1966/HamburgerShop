using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerShop.Context
{
    class MyDbContext:DbContext
    {
        public MyDbContext()
        {
            Database.Connection.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Hamburger01;Integrated Security=true;";
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<OrderSum> OrderSums { get; set; }

    }
}

using MODEL.Entities;
using MODEL.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=MVCProjectDB4;integrated security=true";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> AppUserRoles{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<SubCategory> SubCategories{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetails> OrderDetails{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Map
            modelBuilder.Configurations.Add(new AppUserMap()); modelBuilder.Configurations.Add(new CategoryMap()); modelBuilder.Configurations.Add(new OrderDetailMap()); modelBuilder.Configurations.Add(new OrderMap()); modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SubCategoryMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop.Database
{
    public class HSDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public HSDbContext() : base("HSDbContext")
        {
            System.Data.Entity.Database.SetInitializer(new HSDbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // wylaczenie tworzenia form mnogich
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // globalne wylaczenia usuwania kaskadowego
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<Customer>()
            .Property(c => c.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Customer>().Ignore(c => c.FullName);
        }
    }


}


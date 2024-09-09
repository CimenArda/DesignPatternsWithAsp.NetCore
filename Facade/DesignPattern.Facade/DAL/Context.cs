using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Facade.DAL
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARDACIMEN\\SQLEXPRESS;initial catalog=FacadeDesignPattern;integrated security=true;");


        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARDACIMEN\\SQLEXPRESS;initial catalog=CompositeDesignPattern;integrated security=true;");


        }



        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

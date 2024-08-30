using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARDACIMEN\\SQLEXPRESS;initial catalog=ChainOfResponsibility;integrated security=true;");


        }



        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}

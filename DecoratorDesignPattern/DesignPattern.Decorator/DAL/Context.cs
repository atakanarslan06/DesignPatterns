using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ATAKAN\\MYBLOG;initial catalog=DesignPattern10;integrated security=true;");
        }
       // public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using NorthWindAPI.Model;

namespace NorthWindAPI
{
    public class NorthWindDBContext : DbContext
    {
        public NorthWindDBContext(DbContextOptions<NorthWindDBContext> options):base(options)
        {

        }
        public NorthWindDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees {get;set;}
    }
}

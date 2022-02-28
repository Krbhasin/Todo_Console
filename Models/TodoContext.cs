using Microsoft.EntityFrameworkCore;

namespace TODO.Models
{
    public class TodoContext:DbContext
    {
        private const string connectionString = "server=localhost;database=hello;User Id=root; Password=root";
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
 
        public DbSet<Product> Products { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
namespace Sabadoanimado.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
        {
        }
        public DbSet<concessionaria> carros { get; set; }
        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}

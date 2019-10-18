using Microsoft.EntityFrameworkCore;
using BoredDTO;

namespace BoredApi.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Response> Responses { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using BoredDTO;

namespace BoredApi.Data
{
    public class BoredDbContext :DbContext
    {
        public BoredDbContext(DbContextOptions<BoredDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Response> Responses { get; set; }
    }
}

using BoredApi.Models;
using Microsoft.EntityFrameworkCore;


namespace BoredApi.Data.EFCore
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

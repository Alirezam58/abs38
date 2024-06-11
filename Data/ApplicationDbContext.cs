using abs38.Models;
using Microsoft.EntityFrameworkCore;

namespace abs38.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Projektbeteiligte> projektbeteiligten {  get; set; }
    }
}

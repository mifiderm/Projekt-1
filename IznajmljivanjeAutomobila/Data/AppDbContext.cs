using Microsoft.EntityFrameworkCore;
using IznjamljivanjeAutomobila.Models;

namespace IznjamljivanjeAutomobila.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Automobil> Automobili { get; set; }
    }
}

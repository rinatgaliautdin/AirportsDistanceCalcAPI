using AirportTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AirportTest.DataAccess
{

    public class DataContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
 

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

            modelBuilder.Entity<Airport>()
                .ToTable("Airports"); 
        }

    } 
}

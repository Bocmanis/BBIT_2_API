using Microsoft.EntityFrameworkCore;

namespace BBIT_2_API.Models.Data
{
    public class DataContext : DbContext
    {
        //might be for relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //entity tables for relations
            modelBuilder.Entity<Apartments>()
                .HasOne<Homes>()
                .WithMany()
                .HasForeignKey(p => p.HomeId);
            modelBuilder.Entity<Residents>()
                .HasOne<Apartments>()
                .WithMany()
                .HasForeignKey(p => p.ApartmentId);
        }
        //datacontext is the source of data for the application
        public DataContext(DbContextOptions<DataContext> options) : base(options) //constructor - a method that is called when an object of this class is created
        {           
        }
        public DbSet<Apartments> Apartments { get; set; }
        public DbSet<Homes> Homes { get; set; }
        public DbSet<Residents> Residents { get; set; }

    }
}

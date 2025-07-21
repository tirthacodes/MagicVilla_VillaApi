using MagicVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }



        public DbSet<Villa> Villas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                    new Villa()
                    {
                        Id = 1,
                        Name = "Ronaldo",
                        Details = "lorem",
                        ImageUrl = "https://media.architecturaldigest.com/photos/64471ebe071ada485c0ff168/2:1/w_1280%2Cc_limit/600ClintonPlace-mls-3.jpg",
                        Occupancy = 5,
                        Rate = 200,
                        Sqft = 550,
                        Amenity = "",
                        CreatedDate = DateTime.Now
                    },

                    new Villa()
                    {
                        Id = 2,
                        Name = "Suii",
                        Details = "england",
                        ImageUrl = "https://media.architecturaldigest.com/photos/64471ebe071ada485c0ff168/2:1/w_1280%2Cc_limit/600ClintonPlace-mls-3.jpg",
                        Occupancy = 5,
                        Rate = 400,
                        Sqft = 750,
                        Amenity = "",
                        CreatedDate= DateTime.Now
                    }
                );
        }
    }
}

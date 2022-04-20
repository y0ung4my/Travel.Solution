
using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

                protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
                    .HasData(
                        new Review { ReviewId = 1, City = "Portland", Country = "US", Body = "Great place!", Rating = 5 },
                        new Review { ReviewId = 2, City = "Denver", Country = "US", Body = "Great place!", Rating = 4 },
                        new Review { ReviewId = 3, City = "Seattle", Country = "US", Body = "Great place!", Rating = 3 },
                        new Review { ReviewId = 4, City = "Milwaukee", Country = "US", Body = "Great place!", Rating = 1 },
                        new Review { ReviewId = 5, City = "Chicago", Country = "US", Body = "Great place!", Rating = 2 }
                        );
        }

        public DbSet<Review> Reviews { get; set; }
    }
}
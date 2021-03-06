// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Body = "Great place!",
                            City = "Portland",
                            Country = "US",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 2,
                            Body = "Great place!",
                            City = "Denver",
                            Country = "US",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 3,
                            Body = "Great place!",
                            City = "Seattle",
                            Country = "US",
                            Rating = 3
                        },
                        new
                        {
                            ReviewId = 4,
                            Body = "Great place!",
                            City = "Milwaukee",
                            Country = "US",
                            Rating = 1
                        },
                        new
                        {
                            ReviewId = 5,
                            Body = "Great place!",
                            City = "Chicago",
                            Country = "US",
                            Rating = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

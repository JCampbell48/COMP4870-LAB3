using CommunityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Province>().HasData(
        new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
        new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
        new Province { ProvinceCode = "QC", ProvinceName = "Quebec" }
    );

    modelBuilder.Entity<City>().HasData(
        new City { CityId = 1, CityName = "Vancouver", Population = 675000, ProvinceCode = "BC" },
        new City { CityId = 2, CityName = "Surrey", Population = 517000, ProvinceCode = "BC" },
        new City { CityId = 3, CityName = "Burnaby", Population = 249000, ProvinceCode = "BC" },
        new City { CityId = 4, CityName = "Toronto", Population = 2730000, ProvinceCode = "ON" },
        new City { CityId = 5, CityName = "Ottawa", Population = 934000, ProvinceCode = "ON" },
        new City { CityId = 6, CityName = "Mississauga", Population = 721000, ProvinceCode = "ON" },
        new City { CityId = 7, CityName = "Montreal", Population = 1705000, ProvinceCode = "QC" },
        new City { CityId = 8, CityName = "Quebec City", Population = 542000, ProvinceCode = "QC" },
        new City { CityId = 9, CityName = "Laval", Population = 438000, ProvinceCode = "QC" }
    );
}



}


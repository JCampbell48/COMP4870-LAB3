using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

    public static class SeedData // why is this static?
    {
            // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<City>().HasData(
            GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
         }
    


public static List<Province> GetProvinces() {
        List<Province> Provinces = new List<Province>() {
            new Province() {    
                ProvinceCode="BC",
                ProvinceName="British Columbia",
                Cities = new List<City>()
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
                Cities = new List<City>()
            },
            new Province() {    // 3
                ProvinceCode="SK",
                ProvinceName="Saskatchewan",
                Cities = new List<City>()
            }
        };

        return Provinces;
    }
    public static List<City> GetCities() {
    List<City> Cities = new List<City>() {
        new City() { CityId = 1, CityName = "Surrey", Population = 300000, ProvinceCode = "BC" },
        new City() { CityId = 2, CityName = "Vancouver", Population = 675218, ProvinceCode = "BC" },
        new City() { CityId = 3, CityName = "Burnaby", Population = 249197, ProvinceCode = "BC" },
        new City() { CityId = 4, CityName = "Calgary", Population = 1239220, ProvinceCode = "AB" },
        new City() { CityId = 5, CityName = "Edmonton", Population = 1057796, ProvinceCode = "AB" },
        new City() { CityId = 6, CityName = "Red Deer", Population = 101002, ProvinceCode = "AB" },
        new City() { CityId = 7, CityName = "Saskatoon", Population = 246376, ProvinceCode = "SK" },
        new City() { CityId = 8, CityName = "Regina", Population = 226404, ProvinceCode = "SK" },
        new City() { CityId = 9, CityName = "Prince Albert", Population = 35926, ProvinceCode = "SK" }
    };

    return Cities;
}

    
}

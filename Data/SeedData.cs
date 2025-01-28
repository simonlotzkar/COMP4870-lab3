using System;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> Provinces = [
            new() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new() {
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new() {
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
        ];

        return Provinces;
    }

    public static List<City> GetCities() {
        List<City> Cities = [
            new() {
                CityId = 1,
                CityName = "Vancouver",
                Population = 4000000,
                ProvinceCode = "BC"
            },
            new() {
                CityId = 2,
                CityName = "Victoria",
                Population = 4000000,
                ProvinceCode = "BC"
            },
            new() {
                CityId = 3,
                CityName = "Kelowna",
                Population = 4000000,
                ProvinceCode = "BC"
            },
            new() {
                CityId = 4,
                CityName = "Calgary",
                Population = 5000000,
                ProvinceCode = "AB"
            },
            new() {
                CityId = 5,
                CityName = "Edmonton",
                Population = 3000000,
                ProvinceCode = "AB"
            },
            new() {
                CityId = 6,
                CityName = "Banff",
                Population = 40000,
                ProvinceCode = "AB"
            },
            new() {
                CityId = 7,
                CityName = "Toronto",
                Population = 6000000,
                ProvinceCode = "ON"
            },
            new() {
                CityId = 8,
                CityName = "Missisauga",
                Population = 500000,
                ProvinceCode = "ON"
            },
            new() {
                CityId = 9,
                CityName = "Windsor",
                Population = 500000,
                ProvinceCode = "ON"
            },
        ];

        return Cities;
    }
}

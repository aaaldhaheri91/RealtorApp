using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RealtorApp.Data;
using System;
using System.Linq;

namespace RealtorApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PropertyContext(
                serviceProvider.GetRequiredService<DbContextOptions<PropertyContext>>())
            )
            {
                if (context.Property.Any())
                {
                    return; // DB has been seeded with data
                }
                context.Property.AddRange(
                    new Property
                    {
                        Price = 350000,
                        Address = "12343 Kingsley St",
                        City = "Dearborn",
                        Zip = 48126,
                        YearBuilt = 2020,
                        PropertyType = "single",
                        SquareFeet = 2500,
                        Bedrooms = 5,
                        Bathrooms = 3,
                        GarageCapacity = 2,
                        RelatorName = "Moe Zhar",
                        RelatorPhone = "313-989-2344",
                        RelatorEmail = "Moe@relator.com"
                    },
                    new Property
                    {
                        Price = 255000,
                        Address = "4423 Joanthan St",
                        City = "Dearborn",
                        Zip = 48126,
                        YearBuilt = 1989,
                        PropertyType = "town home",
                        SquareFeet = 1600,
                        Bedrooms = 3,
                        Bathrooms = 2,
                        GarageCapacity = 1,
                        RelatorName = "Moe Zhar",
                        RelatorPhone = "313-989-2344",
                        RelatorEmail = "Moe@relator.com"
                    },
                    new Property
                    {
                        Price = 199000,
                        Address = "4555 Maple St",
                        City = "Dearborn Heights",
                        Zip = 48127,
                        YearBuilt = 1938,
                        PropertyType = "single",
                        SquareFeet = 1982,
                        Bedrooms = 4,
                        Bathrooms = 2,
                        GarageCapacity = 1.5,
                        RelatorName = "Moe Zhar",
                        RelatorPhone = "313-989-2344",
                        RelatorEmail = "Moe@relator.com"
                    },
                    new Property
                    {
                        Price = 848000,
                        Address = "2342 Reuter St",
                        City = "Canton",
                        Zip = 48129,
                        YearBuilt = 2021,
                        PropertyType = "single",
                        SquareFeet = 4800,
                        Bedrooms = 8,
                        Bathrooms = 4,
                        GarageCapacity = 2.5,
                        RelatorName = "Ali Shami",
                        RelatorPhone = "248-999-4543",
                        RelatorEmail = "AliShami@gmail.com"
                    },
                    new Property
                    {
                        Price = 155000,
                        Address = "4242 Westland St",
                        City = "Dearborn Heights",
                        Zip = 48127,
                        YearBuilt = 1992,
                        PropertyType = "town home",
                        SquareFeet = 1052,
                        Bedrooms = 3,
                        Bathrooms = 1.5,
                        GarageCapacity = 1,
                        RelatorName = "Ali Shami",
                        RelatorPhone = "248-999-4543",
                        RelatorEmail = "AliShami@gmail.com"
                    },
                    new Property
                    {
                        Price = 1000000,
                        Address = "1232 Trump St",
                        City = "West Bloomfield",
                        Zip = 24012,
                        YearBuilt = 2019,
                        PropertyType = "Single",
                        SquareFeet = 8000,
                        Bedrooms = 10,
                        Bathrooms = 4,
                        GarageCapacity = 3,
                        RelatorName = "Ali Shami",
                        RelatorPhone = "248-999-4543",
                        RelatorEmail = "AliShami@gmail.com"
                    },
                    new Property
                    {
                        Price = 100000,
                        Address = "2323 Emanon St",
                        City = "Dearborn",
                        Zip = 48126,
                        YearBuilt = 1995,
                        PropertyType = "condo",
                        SquareFeet = 968,
                        Bedrooms = 2,
                        Bathrooms = 1,
                        GarageCapacity = 0,
                        RelatorName = "Ahmed Abdofara",
                        RelatorPhone = "734-355-2424",
                        RelatorEmail = "Abofara@Abofara.com"
                    },
                    new Property
                    {
                        Price = 50000,
                        Address = "7323 Bingham St",
                        City = "Detroit",
                        Zip = 48125,
                        YearBuilt = 1933,
                        PropertyType = "condo",
                        SquareFeet = 750,
                        Bedrooms = 1,
                        Bathrooms = 1,
                        GarageCapacity = 1,
                        RelatorName = "Ahmed Abdofara",
                        RelatorPhone = "734-355-2424",
                        RelatorEmail = "Abofara@Abofara.com"
                    },
                    new Property
                    {
                        Price = 392000,
                        Address = "7242 Kingsley St",
                        City = "Dearborn",
                        Zip = 48126,
                        YearBuilt = 2001,
                        PropertyType = "single",
                        SquareFeet = 2252,
                        Bedrooms = 4,
                        Bathrooms = 2,
                        GarageCapacity = 1,
                        RelatorName = "Zeinab Dabaj",
                        RelatorPhone = "248-999-2323",
                        RelatorEmail = "ZeinabDabaj@relator.com"
                    },
                    new Property
                    {
                        Price = 340000,
                        Address = "7744 Middlesex St",
                        City = "Livonia",
                        Zip = 48122,
                        YearBuilt = 1998,
                        PropertyType = "town home",
                        SquareFeet = 1900,
                        Bedrooms = 3,
                        Bathrooms = 1,
                        GarageCapacity = 1,
                        RelatorName = "Zeinab Dabaj",
                        RelatorPhone = "248-999-2323",
                        RelatorEmail = "ZeinabDabaj@relator.com"
                    },
                    new Property
                    {
                        Price = 92000,
                        Address = "3432 MyStreet St",
                        City = "Dearborn Heights",
                        Zip = 48127,
                        YearBuilt = 1925,
                        PropertyType = "condo",
                        SquareFeet = 932,
                        Bedrooms = 2,
                        Bathrooms = 1.5,
                        GarageCapacity = 1,
                        RelatorName = "Zeinab Dabaj",
                        RelatorPhone = "248-999-2323",
                        RelatorEmail = "ZeinabDabaj@relator.com"
                    },
                    new Property
                    {
                        Price = 128000,
                        Address = "3424 Warren St",
                        City = "Livonia",
                        Zip = 48122,
                        YearBuilt = 1982,
                        PropertyType = "town home",
                        SquareFeet = 1200,
                        Bedrooms = 3,
                        Bathrooms = 2,
                        GarageCapacity = 1,
                        RelatorName = "Zeinab Dabaj",
                        RelatorPhone = "248-999-2323",
                        RelatorEmail = "ZeinabDabaj@relator.com"
                    },
                    new Property
                    {
                        Price = 4000000,
                        Address = "4555 WestBloom St",
                        City = "Beverly Hills",
                        Zip = 24012,
                        YearBuilt = 2021,
                        PropertyType = "single",
                        SquareFeet = 7921,
                        Bedrooms = 9,
                        Bathrooms = 4,
                        GarageCapacity = 2,
                        RelatorName = "Jon Bones",
                        RelatorPhone = "310-212-2323",
                        RelatorEmail = "JonBones@relator.com"
                    },
                    new Property
                    {
                        Price = 1500000,
                        Address = "3232 Hills St",
                        City = "Beverly Hills",
                        Zip = 24012,
                        YearBuilt = 1999,
                        PropertyType = "condo",
                        SquareFeet = 2500,
                        Bedrooms = 5,
                        Bathrooms = 3,
                        GarageCapacity = 2,
                        RelatorName = "Jon Bones",
                        RelatorPhone = "310-212-2323",
                        RelatorEmail = "JonBones@relator.com"
                    },
                    new Property
                    {
                        Price = 255123,
                        Address = "3381 Glade Creek Blvd",
                        City = "Roanoke",
                        Zip = 24012,
                        YearBuilt = 1966,
                        PropertyType = "single",
                        SquareFeet = 1735,
                        Bedrooms = 4,
                        Bathrooms = 2,
                        GarageCapacity = 1.5,
                         RelatorName = "Jon Bones",
                        RelatorPhone = "310-212-2323",
                        RelatorEmail = "JonBones@relator.com"
                    },
                    new Property
                    {
                        Price = 199500,
                        Address = "9987 Mecca St",
                        City = "Roanoke",
                        Zip = 24012,
                        YearBuilt = 1966,
                        PropertyType = "single",
                        SquareFeet = 1200,
                        Bedrooms = 3,
                        Bathrooms = 1,
                        GarageCapacity = 1,
                        RelatorName = "Ahmed Aldhaheri",
                        RelatorPhone = "248-231-2321",
                        RelatorEmail = "AhmedAldhaheri@relator.com"
                    },
                    new Property
                    {
                        Price = 10000000,
                        Address = "6754 Moe St",
                        City = "Queens",
                        Zip = 24017,
                        YearBuilt = 1932,
                        PropertyType = "single",
                        SquareFeet = 3500,
                        Bedrooms = 6,
                        Bathrooms = 2,
                        GarageCapacity = 2,
                        RelatorName = "Ahmed Aldhaheri",
                        RelatorPhone = "248-231-2321",
                        RelatorEmail = "AhmedAldhaheri@relator.com"
                    },
                    new Property
                    {
                        Price = 3000000,
                        Address = "5734 Brooklyn St",
                        City = "Brooklyn",
                        Zip = 24018,
                        YearBuilt = 1991,
                        PropertyType = "condo",
                        SquareFeet = 2500,
                        Bedrooms = 5,
                        Bathrooms = 3,
                        GarageCapacity = 2,
                        RelatorName = "Ahmed Aldhaheri",
                        RelatorPhone = "248-231-2321",
                        RelatorEmail = "AhmedAldhaheri@relator.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
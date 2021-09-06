using AirportTest.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AirportTest.DataAccess
{

    public class AirportDbInitializer
    {
        private static DataContext context;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                InitializeSchedules(context);
            }
        }

        private static void InitializeSchedules(DataContext context)
        {
            if (!context.Airports.Any())
            {
                var airport1 = new Airport { Code = "00AZ", Name = "Name-1", Lon = 34.30559, Lat = -112.16460 };
                var airport2 = new Airport { Code = "00B", Name = "Name-2", Lon = 38.91472, Lat = -76.50472 };
                var airport3 = new Airport { Code = "00C", Name = "Name-3", Lon = 37.20318, Lat = -107.86919 };
                var airport4 = new Airport { Code = "00CA", Name = "Name-4", Lon = 35.35053, Lat = -116.88837 };
                var airport5 = new Airport { Code = "00CL", Name = "Name-5", Lon = 38.63824, Lat = -121.51523 };
                var airport6 = new Airport { Code = "00CO", Name = "Name-6", Lon = 40.62220, Lat = -104.34440 };

                context.Airports.Add(airport1);
                context.Airports.Add(airport2);
                context.Airports.Add(airport3);
                context.Airports.Add(airport4);
                context.Airports.Add(airport5);
                context.Airports.Add(airport6);

                context.SaveChanges();
            } 
        }

    }     
}

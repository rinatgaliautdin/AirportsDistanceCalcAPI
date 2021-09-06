using AirportTest.Models;
using System;

namespace AirportTest.BusinessLogic
{
    public static class DistanceCalculator
    {
        private static int _radius = 6371 * 1000; 

        public static double CalculateDistanceInMeters(Airport port1, Airport port2)
        {
            var f1 = port1.Lat * Math.PI / 180;  
            var f2 = port2.Lat * Math.PI / 180;
            var deltaF = (port2.Lat - port1.Lat) * Math.PI / 180;
            var deltaL  = (port2.Lon - port1.Lon ) * Math.PI / 180;

            var a = Math.Sin(deltaF / 2) * Math.Sin(deltaF / 2) + Math.Cos(f1) * Math.Cos(f2) * Math.Sin(deltaL / 2) * Math.Sin(deltaL / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var d = _radius * c; 

            return d / 1600;
        }
    }
}

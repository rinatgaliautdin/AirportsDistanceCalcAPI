using AirportTest.DataAccess.Interfaces;
using AirportTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportTest.DataAccess.Repositories
{
    public class AirportRepository : EntityBaseRepository<Airport>, IAirportRepository
    {
        public AirportRepository(DataContext context)
            : base(context)
        { }
    }
}

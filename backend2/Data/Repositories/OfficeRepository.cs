using backend2.Models;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Data.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly ApplicationContext _context;

        public OfficeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Office> GetAll() => _context.Offices.ToList();

        public IEnumerable<Office> GetByLatLong(double lat, double longi)
        {
            var coord = new GeoCoordinate(lat, longi);
            List<Office> resultOffices = new List<Office>();
            foreach(Office office in GetAll())
            {
                if(coord.GetDistanceTo(new GeoCoordinate(office.Latitude, office.Longitude)) <= 20000)
                {
                    resultOffices.Add(office);
                }
            }
            return resultOffices.ToList();
        }
    }
}

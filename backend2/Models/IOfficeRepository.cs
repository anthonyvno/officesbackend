using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Models
{
    public interface IOfficeRepository
    {
        IEnumerable<Office> GetAll();
        IEnumerable<Office> GetByLatLong(double lat, double longi);
    }
}

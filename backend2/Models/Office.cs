using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Models
{
    public class Office
    {
        #region properties
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Email { get; set; }
        #endregion

        #region constructors
        public Office()
        {

        }
        public Office(string name, string city, double latitude, double longitude, string email)
        {
            Name = name;
            City = city;
            Latitude = latitude;
            Longitude = longitude;
            Email = email;
        }
        #endregion

        #region methods
        #endregion
    }
}

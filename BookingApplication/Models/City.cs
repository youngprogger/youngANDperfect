using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApplication.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}

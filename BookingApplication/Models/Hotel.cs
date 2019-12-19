using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApplication.Models
{
    public enum TypesOfHotel
    {
        Hotel,
        Appartments,
        Hostel,
        Villa
    }
    public enum Ratings
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
    public class Hotel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public Ratings Rating { get; set; }
        public bool IsAllInclusive { get; set; }
        public TypesOfHotel TypeOfHotel { get; set; }        
    }
}

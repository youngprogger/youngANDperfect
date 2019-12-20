using BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApplication
{
    class DataBaseRepository
    {
        DBContext _context;
        public DataBaseRepository()
        {
            _context = new DBContext();
        }
        public List<City> GetAllCities() => _context.Cities.ToList();
        public List<Country> GetAllCountries() => _context.Countries.ToList();
        public List<Accommodation> GetAllAccommodations() => _context.Accomodations.ToList();
        public List<Hotel> GetAllHotels() => _context.Hotels.ToList();
        public List<User> GetAllUsers() => _context.Users.ToList();
        public void AddAccommmodation(Accommodation accomodation)
        {
            _context.Accomodations.Add(accomodation);
            _context.SaveChanges();
        }

        public void AddAccomodation(Accommodation newAccommodation)
        {
            _context.Accomodations.Add(newAccommodation);
            _context.SaveChanges();
        }
        public void AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
    }
}

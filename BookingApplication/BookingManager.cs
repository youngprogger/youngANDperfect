using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using BookingApplication.Models;

namespace BookingApplication
{


    public class BookingManager
    {
        private User user;
        private DataBaseRepository Repository;
        public BookingManager()
        {
            Repository = new DataBaseRepository();
        }
        public User Autorization(string Login, string Password)
        {
            user = null;
            var users = Repository.GetAllUsers();
            foreach (var u in users)
            {

                if ((u.PhoneNumber == Login || u.Email == Login) && u.Password == Password)
                {
                    user = u;
                }
            }
            return user;
        }//make null extention
        public User Registration(string surname, string name, DateTime dateOfBirht, string email, string phoneNumber, string password)
        {
            {
                var users = Repository.GetAllUsers();
                if (users.Exists(u => (u.Email == email || u.PhoneNumber == phoneNumber) && u.Password == password))
                    user = new User
                    {
                        Name = name,
                        Surname = name,
                        DateOfBirth = dateOfBirht,
                        Email = email,
                        PhoneNumber = phoneNumber,
                        Password = password
                    };
                else
                    user = null;
            }
            return user;
        }
        public List<Country> GetAllCountries() => Repository.GetAllCountries();
        public List<City> GetCitiesForCountry(Country country) => Repository.GetAllCities().Where(c => c.CountryId == country.Id).ToList();
        public Country GetCountryByName(string CountryName) => Repository.GetAllCountries().Find(c => c.Name == CountryName);
        public City GetCityByNameAndCountry(int CountryId, string CityName) => Repository.GetAllCities().Find(c => c.Name == CityName && c.CountryId == CountryId);
        public List<Hotel> GetHotelsByCityAndCountry(int CountryId, int CityId) => Repository.GetAllHotels().Where(h => h.CountryId == CountryId && h.CityId == CityId).ToList();
        public Hotel GetHotelByCityCountryName(int CityId, int CountryId, string Name) => Repository.GetAllHotels().Find(h => h.CityId == CityId && h.CountryId == CountryId && h.Name == Name);
        public List<Accommodation> GetAllAccomodationsByUser(int UserId) => Repository.GetAllAccommodations().Where(a => a.UserId == UserId).ToList();
        public List<User> GetAllUser() => Repository.GetAllUsers().ToList();
        public void AddAccommodation(Accommodation newAccommodation)
        {
            Repository.AddAccomodation(newAccommodation);
        }
        public List<Hotel> GetAllHotels() => Repository.GetAllHotels().ToList();
        public List<Accommodation> GetAllAccommodations() => Repository.GetAllAccommodations().ToList();


    }
}
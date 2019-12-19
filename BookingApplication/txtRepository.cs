using BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookingApplication
{
    class txtRepository
    {
        Hotel hotel;


        private const string FileName = "../../../Data.txt";
        public List<Hotel> Hotels { get; private set; } = new List<Hotel>();
        public List<User> Users { get; private set; } = new List<User>();
        public List<Accommodation> Accommodations { get; private set; } = new List<Accommodation>();

        public void BookingManager()
        {
            try
            {
                LoadData();
            }
            catch
            {
                Console.WriteLine("Error of data loading");
            }
        }
        private void LoadData()
        {

            int count;
            string line;
            string[] parts;
            Hotels = new List<Hotel>();
            Users = new List<User>();
            Accommodations = new List<Accommodation>();

            using (var sr = new StreamReader(FileName))
            {
                //Hotels
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var hotel = new Hotel
                    {   Id = int.Parse(parts[0]),
                        Price = int.Parse(parts[1]),
                        Name = parts[2],
                        CountryId = int.Parse(parts[3]),
                        CityId = int.Parse(parts[4]),
                        Rating = Enum.Parse<Ratings>(parts[5]),
                        IsAllInclusive = bool.Parse(parts[6]),
                        TypeOfHotel = Enum.Parse<TypesOfHotel>(parts[7])

                    };
                    Hotels.Add(hotel);
                    // User
                }
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var user = new User
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Surname = parts[2],
                        DateOfBirth = DateTime.Parse(parts[3]),
                        Email = parts[4],
                        PhoneNumber = parts[5],
                        Password = parts[6],
                        
                    };
                    Users.Add(user);
                    // Accommodation
                }
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(";");
                    var accommodation = new Accommodation
                    {
                        HotelId = int.Parse(parts[0]),
                        UserId = int.Parse(parts[1]),
                        TypeOfPayment = Enum.Parse<TypesOfPayment>(parts[2]),                       
                        DateOfArrive = DateTime.Parse(parts[3]),
                        DateOfDeparture = DateTime.Parse(parts[4])
                    };
                    Accommodations.Add(accommodation);
                }                
            }            
        }
        public void SaveData()
        {
            using ( var save = new StreamWriter(FileName))
            {
                save.WriteLine(Hotels.Count);
                foreach (var hotel in Hotels)
                    save.WriteLine($"{hotel.Name}; {hotel.CountryId}; {hotel.Price}; {hotel.Rating}; {hotel.TypeOfHotel} ");
                save.WriteLine(Users.Count);
                foreach (var user in Users)
                    save.WriteLine($"{user.Name}; {user.Surname}; {user.Password}; {user.PhoneNumber}; {user.Email}; {user.DateOfBirth}; {user.Id}");
                save.WriteLine(Accommodations.Count);
                foreach (var accommodation in Accommodations)
                    save.WriteLine($"{accommodation.DateOfArrive}; {accommodation.DateOfDeparture}; {accommodation.HotelId}; {accommodation.TypeOfPayment}; {accommodation.UserId}");
            }   

        }

    } 
}

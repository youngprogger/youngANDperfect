using BookingApplication;
using BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        BookingManager bookingManager;
        User user;
        Country country;
        City city;
        DateTime startDate;
        DateTime endDate;
        public Search(BookingManager _bookingManager, Country country, City city, DateTime startDate, DateTime endDate,User user)
        {
            InitializeComponent();
            this.country = country;
            this.city = city;
            this.startDate = startDate;
            this.endDate = endDate;
            this.user = user;
            bookingManager = _bookingManager;
            Choose_Box.ItemsSource = bookingManager.GetHotelsByCityAndCountry(country.Id, city.Id).Select(h => h.Name);
        }

        private void Choose_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var hotel = bookingManager.GetHotelByCityCountryName(city.Id, country.Id, Choose_Box.SelectedItem.ToString());
            Name.Text = hotel.Name;
            Price.Text = (hotel.Price * Convert.ToDecimal((endDate - startDate).TotalDays)).ToString();
            Rating.Text = hotel.Rating.ToString();
            IsAllInclusive.Text = hotel.Rating.ToString();
            TypeOfHotel.Text = hotel.TypeOfHotel.ToString();
            
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var search = new MainWindow(bookingManager, user);
            search.Show();
            Close();
        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var booking = new Booking(bookingManager);
            booking.Show();
            Close();
        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var signIn = new SignIn();
            signIn.Show();
            Close();
        }


        private void Book_Button_Click(object sender, RoutedEventArgs e)
        {
            var newAccommodation = new Accommodation
            {
                TypeOfPayment = TypesOfPayment.Online,
                DateOfArrive = startDate,
                DateOfDeparture = endDate,
                HotelId = bookingManager.GetHotelsByCityAndCountry(country.Id, city.Id).First(h => h.Name == Choose_Box.SelectedItem.ToString()).Id,
                UserId = user.Id,
                TotalPayment = Convert.ToDecimal((endDate - startDate).TotalDays) * bookingManager.GetHotelsByCityAndCountry(country.Id, city.Id).First(h => h.Name == Choose_Box.SelectedItem.ToString()).Price
                
                
            };
            bookingManager.AddAccommodation(newAccommodation);
            Hide();
            var book = new Client(user, bookingManager);
            book.Show();
            Close();
        }
    }
}

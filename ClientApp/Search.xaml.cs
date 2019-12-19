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
        Country country;
        City city;
        DateTime startDate;
        DateTime endDate;
        public Search(BookingManager _bookingManager, Country country, City city, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.country = country;
            this.city = city;
            this.startDate = startDate;
            this.endDate = endDate;
            Choose_Box.ItemsSource = bookingManager.GetHotelsByCityAndCountry(country.Id, city.Id).Select(h => h.Name);
        }

        private void Choose_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var hotel = bookingManager.GetHotelByCityCountryName(city.Id, country.Id, Choose_Box.SelectedItem.ToString());
            Name.Text = hotel.Name;
            Price.Text = (hotel.Price * Convert.ToDecimal((endDate - startDate).TotalDays)).ToString();
            Rating.Text = hotel.Rating.ToString();
            IsAllInclusive.Text = hotel.Rating.ToString();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Book_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

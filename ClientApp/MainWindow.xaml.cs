using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookingApplication;
using BookingApplication.Models;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookingManager bookingManager;
        Country country;
        City city;
        public MainWindow()
        { 
            InitializeComponent();
            bookingManager = new BookingManager();
            Choose_Country.ItemsSource = bookingManager.GetAllCountries().Select(c => c.Name);
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Choose_City.SelectedItem != null && Choose_Country.SelectedItem != null && Enter_Arrive.SelectedDate != null && Enter_Departure.SelectedDate != null)
            {
                Hide();
                var search = new Search(bookingManager, country, city, Enter_Arrive.SelectedDate.Value, Enter_Departure.SelectedDate.Value);
                search.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Please, fill all the fields");
            }
        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var booking = new Booking(bookingManager);
            booking.ShowDialog();
            Show();
        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var signInWin = new SignIn(bookingManager);
            signInWin.ShowDialog();
            Show();
        }


        private void Choose_Country_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Choose_City.ItemsSource = bookingManager.GetCitiesForCountry(bookingManager.GetCountryByName(Choose_Country.SelectedItem.ToString())).Select(c => c.Name);
            country = bookingManager.GetCountryByName(Choose_Country.SelectedItem.ToString());
        }

        private void Choose_City_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            city = bookingManager.GetCityByNameAndCountry(country.Id, Choose_City.SelectedItem.ToString());
        }
    }
}

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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        BookingManager _bm;
        User _user;
        public Client(User user, BookingManager bm)
        {
            InitializeComponent();
            _user = user;
            Hello.Text = $"Hello, {user.Name}";
            _bm = bm;
            Trips_List.ItemsSource = _bm.GetAllAccomodationsByUser(user.Id).Select(a => a.DateOfArrive);
        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var booking = new Booking(_bm);
            booking.Show();
            Close();
        }


        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Profile_Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Trips_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var trip = _bm.GetAllAccomodationsByUser(_user.Id).Find(a => a.DateOfArrive.ToString() == Trips_List.SelectedItem.ToString());
            MessageBox.Show(trip.Id + " " + trip.HotelId + " " + trip.TypeOfPayment + " " + trip.DateOfArrive + " " + trip.DateOfDeparture);
        }
    }
}

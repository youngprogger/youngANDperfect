using BookingApplication;
using BookingApplication.Models;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        BookingManager _bookingManager;
        User user;
        public SignIn()
        {
            InitializeComponent();
            _bookingManager = new BookingManager();
            
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var search =  new SignIn();
            search.Show();
            Close();

        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var booking = new Booking(_bookingManager);
            booking.Show();
            Close();
            
        }

       

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var registration = new Registration(_bookingManager);
            registration.ShowDialog();
            Close();

        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            user = _bookingManager.Autorization(Login.Text, Password.Password);
            Hide();
            var clientWin = new Client(user, _bookingManager);
            clientWin.ShowDialog();
            Show();

        }
    }
}

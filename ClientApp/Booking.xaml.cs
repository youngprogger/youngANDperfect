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
    /// Логика взаимодействия для Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        BookingManager _bm;
        User user;
        public Booking(BookingManager bookingManager)
        {
            InitializeComponent();
            _bm = bookingManager;
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        { 
            Hide();
            var mainWindow = new MainWindow(_bm, user);
            mainWindow.Show();
            Close();
        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var signInWin = new SignIn();
            signInWin.Show();
            Close();
        }

        private void _SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var signInWin = new SignIn();
            signInWin.Show();
            Close();
        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

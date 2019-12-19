using BookingApplication;
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
        public SignIn(BookingManager bookingManager)
        {
            InitializeComponent();
            _bookingManager = bookingManager;
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            var user = _bookingManager.Autorization(Login.Text, Password.Password);
            Hide();
            var clientWin = new Client();
            clientWin.ShowDialog();
            Show();
        }
    }
}

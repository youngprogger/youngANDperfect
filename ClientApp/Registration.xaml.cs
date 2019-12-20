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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        BookingManager booking;
        User user;

        public Registration( BookingManager bm)
        {
            InitializeComponent();
            booking = bm;
        }

        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {   if(Name.Text != "" && Surname.Text != "" && DateOfBirth.Text!= "" && PhoneNumber.Text != "" && Email.Text != "" && Login.Text != "" && Password.Text != "")
            {
                user = new User();
                user.Name = Name.Text;
                user.Surname = Surname.Text;
                if (DateTime.TryParse(DateOfBirth.Text, out DateTime date))
                    user.DateOfBirth = date;
                else
                    MessageBox.Show("You fill email in incorrect form.");
                if (booking.GetAllUser().Exists(e => e.Email == Email.Text))
                {
                    MessageBox.Show("This Email is already exist");
                }
                    
                else
                {
                    user.Email = Login.Text;
                    user.Email = Email.Text;

                }
                if (booking.GetAllUser().Exists( l => l.PhoneNumber == PhoneNumber.Text))
                {
                    MessageBox.Show("This Email is already exist");
                }
                else
                {
                    user.PhoneNumber = Login.Text;
                    user.PhoneNumber = PhoneNumber.Text;
                }
                user.Password = Password.Text;

                Hide();
                var enter = new Client(user, booking);
                enter.Show();
                Close();

            }
            else
            {
                MessageBox.Show("Some fields are blank. Please, fill all fields!");
            }

            

        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var mainWindow = new MainWindow(booking, user);
            mainWindow.Show();
            Close();

        }

        private void Bookings_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var bookings = new Booking(booking);
            bookings.Show();
            Close();



        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            var signIn = new SignIn();
            signIn.Show();
            Close();

        }
    }
}

using BookingApplication;
using BookingApplication.Models;
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

namespace ManagerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   BookingManager booking;
        User user;
        Hotel hotel;
        Accommodation acccommodation;
        public MainWindow()
        {
            InitializeComponent();
            this.booking = new BookingManager();
            this.user = new User();
            Users_List.ItemsSource = booking.GetAllUser();
            AllHotels_List.ItemsSource = booking.GetAllHotels();
            var allAccomodations = booking.GetAllAccommodations();
            BusyHotels_List.ItemsSource = booking.GetAllHotels().Where(h => allAccomodations.Any(a => a.HotelId == h.Id));
            Total_Gain.Text = booking.GetAllAccommodations().Sum(a => a.TotalPayment).ToString(); 



        }

        
    }
}

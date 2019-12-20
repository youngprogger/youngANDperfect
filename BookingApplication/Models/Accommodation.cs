using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApplication.Models
{
    public enum TypesOfPayment {
    Cash,
    Online}

    public class Accommodation
    {
        public int Id { get; set; }
        public TypesOfPayment TypeOfPayment { get; set; }
        public int UserId { get; set; }
        public int HotelId { get; set; }
        public DateTime DateOfArrive { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public decimal TotalPayment { get; set; }
    }
}

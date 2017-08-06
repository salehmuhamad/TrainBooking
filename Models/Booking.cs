using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TicketNo { get; set; }
        public string ArrivalPlace { get; set; }
        public string DeparturePlace { get; set; }
        public string CurrentStatus { get; set; }

    }
}
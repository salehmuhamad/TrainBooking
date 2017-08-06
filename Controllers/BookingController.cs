using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainBooking.Models;

namespace TrainBooking.Controllers
{
    public class BookingController : ApiController
    {
        public bool NewCustomer(Customer c)
        {
            return true;
        }
        public bool Booking(Booking b)
        {
            return true;
        }
        public string CheckBookingStatus(string ticketNo)
        {
            Booking b = new Booking();
            return b.CurrentStatus;
        }
        public bool CancelBooking(int BookingId)
        {
            return true;
        }
        public List<string> getBookings()
        {
            List<string> bookings = new List<string>();
            return bookings;
        }
    }
}

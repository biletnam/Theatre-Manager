using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpec
{
    class Seat
    {
        private Customer customer;
        private DateTime bookingdate;
        private DateTime showdate;
        private enum SeatState
        {
            Empty,
            Reserved,
            Booked
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using modulo11.aula4.Ecceptions;

namespace modulo11.aula4.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut < checkIn)
            {
                throw new DomainException("Checkout date must be after check");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation for updates must be future dates");
            }
            if(checkout < checkin)
            {
                throw new DomainException("Checkout date must be after check");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}

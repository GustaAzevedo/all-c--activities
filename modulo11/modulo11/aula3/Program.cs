using System;
using System.Collections.Generic;
using System.Text;
using modulo11.aula3.Entities;

namespace modulo11.aula3
{
    class Programa
    {
        static void x()
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Checkout date must be after check");
            }
            else
            {
                Reservation reserva = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reserva);

                Console.WriteLine();
                Console.Write("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                if(checkout < DateTime.Now || checkin < DateTime.Now)
                {
                    Console.WriteLine("Error in reservation: Reservations dates for updates must be future dates");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Error in reservation: Checkout date must be after check");
                }
                else
                {
                    reserva.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reserva);
                }
            }

        }
    }
}

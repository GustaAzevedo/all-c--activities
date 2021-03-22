using System;
using System.Collections.Generic;
using System.Text;
using modulo11.aula4.Entities;
using modulo11.aula4.Ecceptions;

namespace modulo11.aula4
{
    class Programa
    {
        static void x()
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reserva = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reserva);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reseration" + e.Message );
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Incorect Format" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Unexpected Error" + e.Message);
            }

            

        }
    }
}

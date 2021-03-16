using System;
using System.Collections.Generic;
using System.Text;
using modulo9.Entities;
using modulo9.Entities.Enums;

namespace modulo9
{
    class aulaUm
    {
        static void Main()
        {
            Order x = new Order
            {
                Id = 2,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(x);

            string txt = OrderStatus.PandingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}

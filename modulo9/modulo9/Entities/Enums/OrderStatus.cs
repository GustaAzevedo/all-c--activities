using System;
using System.Collections.Generic;
using System.Text;

namespace modulo9.Entities.Enums
{
    enum OrderStatus : int
    {
        PandingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ExercicioUm.Entities.Entities;

namespace ExercicioUm.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(OrderItem i in Items)
            {
                total += i.subTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder x = new StringBuilder();
            x.AppendLine("ORDER SUMMARY:");
            x.Append("Order moment:");
            x.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            x.Append("Order status: ");
            x.AppendLine(Status.ToString());
            x.Append("Client: ");
            x.Append(Client.Name);
            x.Append(" (");
            x.Append(Client.BirtDate.Date);
            x.Append(") - ");
            x.AppendLine(Client.Email);
            x.AppendLine("ORDER SUMMARY");
            foreach(OrderItem i in Items)
            {
                
                x.Append(i.Product.Name);
                x.Append(", ");
                x.Append(i.Price.ToString("F2", CultureInfo.InvariantCulture));
                x.Append(", Quantity: ");
                x.Append(i.Quantity);
                x.Append(", Subtotal: $");
                x.AppendLine(i.subTotal().ToString());
            }
            x.Append("Total price: $");
            x.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return x.ToString();

        }
    }
}

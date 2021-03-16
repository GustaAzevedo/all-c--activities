using System;
using ExercicioUm.Entities;
using ExercicioUm.Entities.Entities;
using System.Globalization;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");           
            Console.Write("Name: ");
            string ClientName = Console.ReadLine();
            Console.Write("Email: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth date (dd/MM/yyyyy): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Status ( PendingPayment /Processing /Shipped /Delivered ): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Client cliente = new Client(ClientName, ClientEmail, birthday);
            Order pedido = new Order(dataAtual, status, cliente);

            Console.WriteLine("nome cliente " + pedido.Client.Name + " Email: " + pedido.Client.Email + " status do pedido: " + pedido.Status + " pedido momento: " + pedido.Moment);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantiy: ");
                int qtd = int.Parse(Console.ReadLine());

                Product produto = new Product(ProductName, ProductPrice);
                OrderItem itemProduto = new OrderItem(qtd, ProductPrice, produto);
                pedido.AddItem(itemProduto);
            }

            Console.WriteLine();
            Console.WriteLine(pedido);

            
        }
    }
}

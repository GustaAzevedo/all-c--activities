using System;
using System.Globalization;
using alugaCarro.Entities;
using alugaCarro.Entities.Enums;

namespace alugaCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a empresa que o cliente trabalha: ");
            string emp = Console.ReadLine();
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Por quantas semanas pretende alugar o carro?: ");
            int semanas = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do cliente: ");
            int idadeCliente = int.Parse(Console.ReadLine());
           

            Empresa empresa = new Empresa(emp);
            Cliente cliente = new Cliente(nomeCliente, semanas, idadeCliente, empresa);

            bool passaIdade = cliente.checaIdade();

            if (passaIdade == true)
            {
                Console.WriteLine();

                bool empresaVazia = string.IsNullOrWhiteSpace(emp);
                if (empresaVazia == true)
                {
                    Console.WriteLine($"O cliente {cliente.Nome}, com a idade de: {cliente.Idade} anos, está apto para dar prosseguir com alugguel do automovel");
                }
                else
                {
                    Console.WriteLine($"O cliente {cliente.Nome}, que trabalha na empresa {cliente.Empresa.Nome}, com a idade de: {cliente.Idade} anos, está apto para dar prosseguir com alugguel do automovel");
                }

                Console.WriteLine();
                Console.Write("O cliente deseja um carro de qual categoria? Digite corretamente uma das opções ( CategoriaA / CategoriaB / CategoriaC): ");
                CarroCategoria categoria = Enum.Parse<CarroCategoria>(Console.ReadLine());
                Console.Write("Qual é o nome do veículo que o cliente deseja: ");
                string nomeCarro = Console.ReadLine();
                Console.Write("O preço do veículo: ");
                double precoCarro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Carro carroCliente = new Carro(nomeCarro, precoCarro, categoria);
                Cliente cliente1 = new Cliente(nomeCliente, idadeCliente, semanas, carroCliente, empresa);

                double valorTotal = cliente1.Valortotal();

                if(categoria == Enum.Parse<CarroCategoria>("CategoriaA"))
                {
                    valorTotal = valorTotal + 200;
                }
                else if(categoria == Enum.Parse<CarroCategoria>("CategoriaB"))
                {
                    valorTotal += 100;
                }
                else
                {
                    valorTotal += 50;
                }

                Console.WriteLine(cliente1.ToString() + "" + valorTotal);





            }
            else
            {
                Console.WriteLine("Não Podemos prosseguir com o cadastro, pois o cliente é menor de idade");
            }


            

        }
    }
}

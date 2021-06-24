using System;
using Entities;
namespace _04___Manual___Class_Exercise_1._0 {
    class Program {
        static void Main(string[] args) {
            Stock stock = new Stock();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Entre com os valores dos dados do produto");
            Console.Write("Nome do produto: "); stock.Name = Console.ReadLine();
            Console.Write("Preço do produto: "); stock.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: "); stock.Amount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(stock);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: "); int add = int.Parse(Console.ReadLine());
            stock.AddProduct(add);
            Console.Write("Digite o número de produtos a ser removido do estoque: "); int remove = int.Parse(Console.ReadLine());
            stock.RemoveProduct(remove);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(stock);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}


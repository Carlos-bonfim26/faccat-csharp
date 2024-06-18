using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer40
    {
        
        public static void Main(string[] args) {
            string nome; int quantidade; float precoUni, precoTotal;

            Console.WriteLine("digite o nome do produto:");
            nome = Console.ReadLine();
            Console.WriteLine($"digite quantos {nome} você comprou:");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"digite o preço unitário do {nome}:");
            precoUni = float.Parse(Console.ReadLine());

            precoTotal = quantidade * precoUni;

            if (quantidade > 10)
            {
                Console.WriteLine($"{quantidade} {nome} custam R${precoTotal - precoTotal / 100 * 5}");
            } else if (quantidade > 5)
            {
                Console.WriteLine($"{quantidade} {nome} custam R${precoTotal - precoTotal / 100 * 3}");
            }
            else
            {
                Console.WriteLine($"{quantidade} {nome} custam R${precoTotal - precoTotal / 100 * 2}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("qual é o custo de fábrica do carro:");
            float carro = float.Parse(Console.ReadLine());

            Console.WriteLine("o preço do carro com os impostos é R$" + (carro + (carro / 100 * 28) + (carro / 100 * 45)));
        }
    }
}

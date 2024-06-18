using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade miníma que tem estoque:");
            float minima = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade maxíma que tem estoque:");
            float maxima = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade que tem estoque:");
            float atual = float.Parse(Console.ReadLine());

            float media = (minima + maxima) / 2;

            if (atual > media)
            {
                Console.WriteLine("não efetuar compra.");
            }
            else
            {
                Console.WriteLine("efetuar compra.");
            }
        }
    }
}

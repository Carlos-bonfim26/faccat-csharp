using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine($"{n} é negativo");
            }
            else
            {
                Console.WriteLine($"{n} é positivo");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número inteiro:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine($"{n} é maior que 10");
            }
            else
            {
                Console.WriteLine($"{n} é menor que 10");
            }
        }
    }
}

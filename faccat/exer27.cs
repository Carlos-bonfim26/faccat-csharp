using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("zero");
            } else if (n < 0)
            {
                Console.WriteLine("positivo");
            }
            else
            {
                Console.WriteLine("negativo");
            }
        }
    }
}

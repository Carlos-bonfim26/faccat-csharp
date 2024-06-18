using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer33
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um número:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro número:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("iguais");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("segundo maior");
            }
            else
            {
                Console.WriteLine("primeiro maior");
            }
        }
    }
}

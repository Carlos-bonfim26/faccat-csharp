using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("quantas maçãs você comprou?");
            int maca = Convert.ToInt32(Console.ReadLine());

            if (maca < 1)
            {
                Console.WriteLine("ERRO!!!");
            } else if (maca < 12)
            {
                Console.WriteLine($"{maca} maças custam R${maca * 1.30}");
            }
            else
            {
                Console.WriteLine($"{maca} maças custam R${maca }");
            }
        }
    }
}

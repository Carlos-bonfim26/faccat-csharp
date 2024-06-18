using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer36
    {
        public static void Main(string[] args)
        {
            int[] idadeH = new int[2];
            int[] idadeM = new int[2];

            for (int i = 0; i < idadeH.Length; i++)
            {
                Console.WriteLine($"digite a idade do {i + 1}° homem");
                idadeH[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"digite a idade da {i + 1}° mulher");
                idadeM[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"soma da idade do homem mais velho e mulher mais nova: {idadeH.Max() + idadeM.Min()}");
            Console.WriteLine($"soma da idade da mulher mais velho e homem mais novo: {idadeM.Max() + idadeH.Min()}");

        }
    }
}

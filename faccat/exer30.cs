using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer30
    {
        public static void Main(string[] args)
        {
            int[] num = new int[3];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° número inteiro:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(num);
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer19
    {
        public static void Main(string[] args)
        {
            float[] n = new float[2];

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° número");
                n[i] = float.Parse(Console.ReadLine());

            }
            Console.WriteLine($"o maior número é {Math.Max(n[0], n[1])}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer20
    {
        public static void Main(string[] args)
        {
            float[] n = new float[2];

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° número");
                n[i] = float.Parse(Console.ReadLine());

            }
            if (n[0] > n[1])
            {
                Console.WriteLine($"{n[1]},{n[0]}");
            }
            else
            {
                Console.WriteLine($"{n[0]},{n[1]}");
            }
        }
    }
}

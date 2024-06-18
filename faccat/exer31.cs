using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer31
    {
        public static void Main(string[] args)
        {
            double[] lado = new double[3];

            for (int i = 0; i < lado.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° número inteiro:");
                lado[i] = Convert.ToDouble(Console.ReadLine());
            }

            if (lado[0] > lado[1] + lado[2] || lado[1] > lado[0] + lado[2] || lado[2] > lado[0] + lado[1])
            {
                Console.WriteLine("não forma um triângulo");
            }
            else
            {
                Console.WriteLine("forma um triângulo");
            }
        }
    }
}

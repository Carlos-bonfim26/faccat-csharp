using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer43
    {
        public static void Main(string[] args)
        {
            float[] lado = new float[3];

            for (int i = 0; i < lado.Length; i++)
            {
                Console.WriteLine($"digite o {i + 1}° lado do triângulo:");
                lado[i] = float.Parse(Console.ReadLine());
            }
            if (lado[0]> lado[1] + lado[2] || lado[1] > lado[0] + lado[2] || lado[2] > lado[0] + lado[1])
            {
                Console.WriteLine("não é um triângulo");
            } else if (lado[0] == lado[1] && lado[1] == lado[2])
            {
                Console.WriteLine("triângulo equilátero");
            } else if (lado[0] == lado[1] || lado[1] == lado[2] || lado[0] == lado[2])
            {
                Console.WriteLine("triângulo isósceles");
            }
            else
            {
                Console.WriteLine("triângulo escaleno");
            }
        }
    }
}

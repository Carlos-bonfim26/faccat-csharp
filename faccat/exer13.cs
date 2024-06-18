using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer13
    {
        public static void Main(string[] args)
        {
            float[] nota = new float[3];
            float[] peso = { 2, 3, 5 };
            float acumulador = 0;

            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine($"digite a {i + 1}° nota:");
                nota[i] = float.Parse(Console.ReadLine()) * peso[i];
                acumulador += nota[i];
            }
            Console.WriteLine($"sua nota final foi de {acumulador / 10}");
        }
    }
}

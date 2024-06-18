using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer17
    {
        public static void Main(string[] args)
        {
            float[] nota = new float[2];
            float media,acumulador = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine($"digite a {i + 1} nota");
                nota[i] = float.Parse(Console.ReadLine());

                acumulador += nota[i];
            }
            media = acumulador / nota.Length;
            if (media < 6)
            {
                Console.WriteLine($"sua nota média é {media}, você está reprovado.");
            }
            else
            {
                Console.WriteLine($"sua nota média é {media}, você está aprovado.");
            }
        }
    }
}

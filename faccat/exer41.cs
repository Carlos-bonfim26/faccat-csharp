using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer41
    {
        public static void Main(string[] args)
        {
            float[] nota = new float[4];
            float[] peso = {1, 2, 3, 1};

            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine($"digite a {i +1}° nota:");
                nota[i] = float.Parse(Console.ReadLine()) * peso[i];
            }
            float media = nota.Sum() / 7;

            if (media < 6)
            {
                Console.WriteLine($"Nota D {media}");
            }
            else if(media < 7.5)
            {
                Console.WriteLine($"Nota C {media}");
            } else if (media < 9)
            {
                Console.WriteLine($"Nota B {media}");
            }
            else
            {
                Console.WriteLine($"Nota A {media}");
            }
        }
    }
}

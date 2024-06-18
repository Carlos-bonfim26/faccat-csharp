using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer08
    {
        public static void Main(string[] args)
        {
            string[] cargo = new string[]{ "Brancos", "nulos", "válidos" };
            double[] votos = new double[3];
         
            double totalVotos = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                Console.WriteLine($"digite a quantidade de votos {cargo[i]}");
                votos[i] = Convert.ToDouble(Console.ReadLine());
                totalVotos += votos[i];
            }
            Console.WriteLine($"a quantidade de votos totais é de {totalVotos} votos");
            for (int x = 0; x < votos.Length; x++)
            {
           
                Console.WriteLine($"{votos[x] / totalVotos * 100d}% é o percentual de votos {cargo[x]}");
            }
        }
    }
}

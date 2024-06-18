using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite  base do retângulo");
            float baseR = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite  altura do retângulo");
            float altura = float.Parse(Console.ReadLine());

            float area = baseR * altura;

            Console.WriteLine($"a área do retângulo é {area}");
        }
    }
}

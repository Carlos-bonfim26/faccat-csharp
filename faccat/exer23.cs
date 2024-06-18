using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer23
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite seu sexo M ou F:");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Digite sua altura");
            float altura = float.Parse(Console.ReadLine());

            switch (sexo) {
                case 'M':
                    Console.WriteLine($"seu peso ideal é de {72.7f * altura - 58f }");
                break;
                case 'F':
                    Console.WriteLine($"seu peso ideal é de {62.1f * altura - 44.7f}");
                break;
                default:
                    Console.WriteLine("Valor inválido");
                break;
            }

        }
    }
}

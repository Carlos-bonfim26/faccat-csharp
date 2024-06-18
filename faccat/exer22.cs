using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o seu salário por hora:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("digite quantas horas você trabalhou na semana:");
            int hora = Convert.ToInt32(Console.ReadLine());

            if (hora > 40)
            {
                Console.WriteLine($"seu salário é de R${40 * salario + ((hora - 40) *2 )}");
            }
            else
            {
                Console.WriteLine($"seu salário é de R${salario * hora}");
            }
        }
    }
}

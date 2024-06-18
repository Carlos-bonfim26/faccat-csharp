using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o seu reajuste salárial: ");
            float reajuste = float.Parse(Console.ReadLine());


            Console.WriteLine($"o seu novo salário é de {salario + (salario / 100 * reajuste)}");
        }
    }
}

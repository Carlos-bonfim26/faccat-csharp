using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer24
    {
        public static void Main(string[] args)
        {
            float salario, venda, salarioTotal;

            Console.WriteLine("digite o seu salário:");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("digite quanto você ganhou em vendas:");
           venda  = float.Parse(Console.ReadLine());

            if (venda > 1500)
            {
                salarioTotal = salario + (venda / 100 * 3) + ((venda - 1500) / 100 * 5);
                Console.WriteLine($"o seu salário é de R${salarioTotal}");
            }
            else
            {
                salarioTotal = salario + (venda / 100 * 3);
                Console.WriteLine($"o seu salário é de R${salarioTotal}");
            }
        }
    }
}

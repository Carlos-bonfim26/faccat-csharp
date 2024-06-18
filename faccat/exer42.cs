using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o ano que você nasceu");
            int idade = 2024 - Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("em que ano você entrou na empresa");
            int tempoEmpresa = 2024 - Convert.ToInt32(Console.ReadLine());

            if (idade > 65 || tempoEmpresa > 30 || (idade > 60 && tempoEmpresa > 25))
            {
                Console.WriteLine("requer aposentadoria");
            }
            else
            {
                Console.WriteLine("não requer aposentadoria");
            }
        }
    }
}

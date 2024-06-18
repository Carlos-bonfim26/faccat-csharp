using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o ano que você nasceu:");
            int anoNasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o ano atual:");
            int anoAtual = Convert.ToInt32(Console.ReadLine());
          int  idade = anoAtual - anoNasc;

            if (idade < 16)
            {
                Console.WriteLine("você não pode votar");
            }
            else
            {
                Console.WriteLine("você pode votar");
            }


        }
    }
}

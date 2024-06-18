using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("quantos anos completos você tem?");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantos meses completos após se último aniversário você tem?");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantos dias  você tem após seu último mês-versário?");
            int dia = Convert.ToInt32(Console.ReadLine());

            int diasVividos = ano * 365 + mes * 30 + dia;
            Console.WriteLine($"você já viveu {diasVividos} dias");
        }
    }
}

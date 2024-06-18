using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite que horas inteiras  começou o jogo:");
            int comeco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite que horas inteiras  terminou o jogo:");
            int termino = Convert.ToInt32(Console.ReadLine());

            int duracao;

            if (comeco == termino)
            {
                duracao = comeco - termino + 24;
                Console.WriteLine($"o jogo durou {duracao}h");
            }

           else if (termino < comeco)
            {
                duracao = termino - comeco + 24;
               
                Console.WriteLine($"o jogo durou {duracao}h");
            }
            else
            {
                duracao = termino - comeco;
                Console.WriteLine($"o jogo durou {duracao}h");
            }
        }
    }
}

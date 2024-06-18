using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer32
    {
        public static void Main(string[] args)
        {
            string[] time = new string[2];
            int[] gol = new int[2];

            for (int i = 0; i < time.Length; i++)
            {
                Console.WriteLine($"digite o nome dá {i + 1}° equipe da partida:");
                time[i] = Console.ReadLine();
                Console.WriteLine($"digite quantos gol fez o {i + 1}° {time[i]}:");
                gol[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (gol[0] == gol[1])
            {
                Console.WriteLine($"empataram {time[0]} {gol[0]} x {gol[1]} {time[1]} ");
            } else if (gol[0] > gol[1])
            {
                Console.WriteLine($"{time[0]} ganhou em casa, {time[0]} {gol[0]} x {gol[1]} {time[1]} ");
            }
            else
            {
                Console.WriteLine($"{time[1]} ganhou fora de casa, {time[0]} {gol[0]} x {gol[1]} {time[1]} ");
            }
        }
    }
}

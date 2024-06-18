using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite quantos kg de morango você comprou:");
            float morangoKG = float.Parse(Console.ReadLine());
            Console.WriteLine("digite quantos kg de maça você comprou:");
            float macaKG = float.Parse(Console.ReadLine());

            float morangoPreco, macaPreco;

            if (morangoKG > 5)
            {
                morangoPreco = morangoKG * 2.20f;
            }
            else
            {
                morangoPreco = morangoKG * 2.50f;
            }
            if (macaKG > 5)
            {
                macaPreco = morangoKG * 1.50f;
            }
            else
            {
                macaPreco = morangoKG * 1.80f;
            }
            float totalPreco = macaPreco + morangoPreco;
            float totalKG = morangoKG + macaKG;
            if (totalPreco >25 || totalKG > 8 )
            {
                Console.WriteLine($"{totalKG}KG de fruta custou R${totalPreco - totalPreco / 10}");
            }
            else
            {
                Console.WriteLine($"{totalKG}KG de fruta custou R${totalPreco}");
            }
        }
    }
}

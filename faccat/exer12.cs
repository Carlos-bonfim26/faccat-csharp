using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura em celcius:");
            float c = float.Parse(Console.ReadLine());
            float f = (9 * c + 160) / 5;

            Console.WriteLine($"{c}°c = {f}°f");
        }
    }
}

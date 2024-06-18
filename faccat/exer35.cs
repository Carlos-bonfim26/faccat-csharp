using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o tipo do combustivel: A (álcool) ou G (Gasolina)");
            char combustivel = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("quantos litros você comprou");
            float litros = float.Parse(Console.ReadLine());
            float preco;
            switch (combustivel)
            {
                case 'A':
                    preco = litros * 2.90f;
                    if (litros > 20)
                    {
                        preco = preco - (preco / 100 * 5);
                        Console.WriteLine($"{litros}L de Álcool R${preco}");
                    }
                    else
                    {
                        preco = preco - (preco / 100 * 3);
                        Console.WriteLine($"{litros}L de Álcool R${preco}");
                    }
                break;
                case 'G':
                    preco = litros * 3.30f;
                    if (litros > 20)
                    {
                        preco = preco - (preco / 100 * 6);
                        Console.WriteLine($"{litros}L de Gasolina R${preco}");
                    }
                    else
                    {
                        preco = preco - (preco / 100 * 4);
                        Console.WriteLine($"{litros}L de Gasolina R${preco}");
                    }
                    break;
                default:
                    Console.WriteLine("inválido");
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite seu salário fixo:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("digite sua comissão por carro vendido:");
            float comissao = float.Parse(Console.ReadLine());
            Console.WriteLine("digite quantos carros foram vendido:");
            int carro = int.Parse(Console.ReadLine());
            Console.WriteLine("digite quantos reais em carros foram vendido:");
            float valorVendas = float.Parse(Console.ReadLine()) / 100f * 5f;

            float salarioTotal = salario + valorVendas + comissao * carro;

            Console.WriteLine($"seu salário final é de {salarioTotal}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer25
    {
        public static void Main(string[] args)
        {
            string[] pagamento = { "Debíto", "Crédito", "Saldo" };
            double[] valor = new double[pagamento.Length];
            double saldoAtual;
            Console.WriteLine("digite o número da conta:");
            string nConta = Console.ReadLine();

            for (int i = 0; i < pagamento.Length; i++)
            {
                Console.WriteLine($"digite quantos reais você tem no {pagamento[i]}");
                valor[i] = Convert.ToDouble(Console.ReadLine());
            }
            saldoAtual = valor[2] - valor[0] + valor[1];

            if(saldoAtual < 0)
            {
                Console.WriteLine($"saldo negativo: R${saldoAtual}");
            }
            else
            {
                Console.WriteLine($"saldo Positivo: R${saldoAtual}");
            }
        }
    }
}

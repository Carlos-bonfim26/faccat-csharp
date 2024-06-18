using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faccat
{
    internal class exer38
    {
        public static void Main(string[] args)
        {
            int usuario, senha;
            string acesso;
            Console.WriteLine("digite o código de usuário:");
            usuario = Convert.ToInt32(Console.ReadLine());
            if (usuario == 1234)
            {
                Console.WriteLine("digite a senha:");
                senha = Convert.ToInt32(Console.ReadLine());
                acesso = senha == 9999 ? "acesso concedido" : "acesso negado";
                Console.WriteLine(acesso);

            }
            else
            {
                Console.WriteLine("usuário inválido");
            }
        }
    }
}

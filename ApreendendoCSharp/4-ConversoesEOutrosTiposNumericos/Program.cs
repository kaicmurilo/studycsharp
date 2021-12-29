using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4: ");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;
            //variável 32 bits

            long idade = 130000000000000;
            //variável 64 bits


            short quantidadeProdutos = 150;
            //variável 16 bits


            Console.ReadLine();

        }
    }
}

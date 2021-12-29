using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5: ");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);
            string titulo = "ESTUDANDO CURSO " + 2020;
            Console.WriteLine(titulo);




            Console.ReadLine();
        }
    }
}

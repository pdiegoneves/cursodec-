using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_com_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Joao da Silva Sauro";
            string ultimoNome = nome.Substring(nome.IndexOf("Silva"), "Silva".Length);
            Console.WriteLine(ultimoNome);

            Console.ReadKey();
        }
    }
}

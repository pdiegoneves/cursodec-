using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            UInt32 idade = Convert.ToUInt32(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            } 
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
            Console.ReadKey();
        }
    }
}

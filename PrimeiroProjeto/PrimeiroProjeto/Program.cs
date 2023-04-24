using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            UInt16 idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o numero do seu documento:");
            string documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua:");
            string nomeDaRua = Console.ReadLine();

            Console.WriteLine("Digite o número da casa:");
            UInt32 numeroDaCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu sexo. Pressione F para Feminino e M para Masculino:");
            string sexo = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine("Olá " + nome);
            Console.WriteLine("Você tem " + idade + " anos de idade.");
            Console.WriteLine("O número do documento informado é: " + documento);
            Console.WriteLine("O nome da sua rua é: " + nomeDaRua);
            Console.WriteLine("O número da sua casa é: " + numeroDaCasa);
            Console.WriteLine("O seu sexo é: " + sexo);

            Console.WriteLine("Pressione qualquer tecla para encerrar."); 

            Console.ReadKey();
        }
    }
}

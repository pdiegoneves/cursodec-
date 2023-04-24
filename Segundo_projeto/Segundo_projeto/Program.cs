using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora:");
            char opcao = Console.ReadKey(true).KeyChar;
            switch(opcao)
            {
                case 'a':
                    AlugarUmFilme();
                    break;
                case 'A':
                    AlugarUmFilme();
                    break;
                case 's':
                    SairDaLocadora();
                    break;
                case 'S':
                    SairDaLocadora();
                    break;
                default:
                    Console.WriteLine("Pressione A ou S");
                    break;
            }
            
            void AlugarUmFilme()
            {
                Console.WriteLine("Pressine 1 para alugar Top Gun");
                Console.WriteLine("Pressine 2 para alugar A Bela e a Fera");
                Console.WriteLine("Pressine 3 para alugar O Homem Aranha");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch(opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou Top Gun");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou A Bela e a Fera");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou O Homem Aranha");
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar");
            void SairDaLocadora()
            {
                Console.WriteLine("Muito obrigado volte sempre");
            }

            Console.ReadKey();
        }
    }
}

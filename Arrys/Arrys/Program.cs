using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] MeuArray1 = new int[3];
            MeuArray1[0] = 1;
            MeuArray1[1] = 10;
            MeuArray1[2] = 100;
            Console.WriteLine(MeuArray1[0]);
            Console.WriteLine(MeuArray1[1]);
            Console.WriteLine(MeuArray1[2]);

            //Outras maneiras de criar um Array
            int[] MeuArray2 = { 1, 10, 100 };
            Console.WriteLine(MeuArray2[0]);
            Console.WriteLine(MeuArray2[1]);
            Console.WriteLine(MeuArray2[2]);

            int[] MeuArray3 = new int[] { 1, 10, 100 };
            Console.WriteLine(MeuArray3[0]);
            Console.WriteLine(MeuArray3[1]);
            Console.WriteLine(MeuArray3[2]);

            //Array de Duas Dimensões
            string[,] MeuArray4 = new string[2, 3];
            MeuArray4[0, 0] = "1";
            MeuArray4[0, 1] = "2";
            MeuArray4[0, 2] = "3";
            MeuArray4[1, 0] = "11";
            MeuArray4[1, 1] = "12";
            MeuArray4[1, 2] = "13";
            Console.WriteLine(MeuArray4[0,0]);
            Console.WriteLine(MeuArray4[0,1]);
            Console.WriteLine(MeuArray4[0,2]);
            Console.WriteLine(MeuArray4[1,0]);
            Console.WriteLine(MeuArray4[1,1]);
            Console.WriteLine(MeuArray4[1,2]);

            //Outras maneiras de inicializar um array de duas dimansões
            string[,] MeuArray5 = { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(MeuArray5[0, 0]);
            Console.WriteLine(MeuArray5[0, 1]);
            Console.WriteLine(MeuArray5[0, 2]);
            Console.WriteLine(MeuArray5[1, 0]);
            Console.WriteLine(MeuArray5[1, 1]);
            Console.WriteLine(MeuArray5[1, 2]);


            string[,] MeuArray6 = new string[,] { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.WriteLine(MeuArray6[0, 0]);
            Console.WriteLine(MeuArray6[0, 1]);
            Console.WriteLine(MeuArray6[0, 2]);
            Console.WriteLine(MeuArray6[1, 0]);
            Console.WriteLine(MeuArray6[1, 1]);
            Console.WriteLine(MeuArray6[1, 2]);

            //O número de elementos do Array
            int tamanho1 = MeuArray6.GetLength(0);
            int tamanho2 = MeuArray6.GetLength(1);
            Console.WriteLine("A primeira dimensão do MeuArray6 possui: " + tamanho1 + " elementos");
            Console.WriteLine("A segunda dimensão do MeuArray6 possui: " + tamanho2 + " elementos");


            //Array com 3 dimensões
            int[,,] MeuArray7 = new int[2, 2, 2];
            MeuArray7[0, 0, 0] = 1;
            MeuArray7[0, 0, 1] = 1;
            MeuArray7[0, 1, 0] = 1;
            MeuArray7[0, 1, 1] = 1;

            Console.WriteLine(MeuArray7[0, 0, 0]);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade = 18;
            Idade = 36;
            Console.WriteLine(Idade);
            Idade = 20;
            Console.WriteLine(Idade);

            string NomeCompleto = "Guilherme Alvez";
            Console.WriteLine(NomeCompleto);

            NomeCompleto = "Joana Martins";
            Console.WriteLine(NomeCompleto);

            //byte b = 1000; -> 1000 é  uito grande para uma variável do tipo byte, vai dar erro

            var Salario = 10000;
            var NomeDaMae = "Joana";
            // NomeDaMae = 10000; ->Não é possível pois o compilador já atribuiu o tipo string a variável

            DateTime DataDeNascimento = new DateTime(1988, 7, 10, 7, 15, 10);
            Console.WriteLine(DataDeNascimento.Year);
            Console.WriteLine(DataDeNascimento.Month);
            Console.WriteLine(DataDeNascimento.Day);
            Console.WriteLine(DataDeNascimento.Hour);
            Console.WriteLine(DataDeNascimento.Minute);
            Console.WriteLine(DataDeNascimento.Second);


            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);

            Console.WriteLine(NumeroDaCasaInt);

            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);
            Console.WriteLine(NumeroDaCasa2);

            byte b = 50;
            char c = Convert.ToChar(b); // Utiliza a tabela ASCII
            Console.WriteLine(c);

            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC);

            double d = 1.6;
            Console.WriteLine(d);

            int ConversaoDoDouble = Convert.ToInt32(d);
            Console.WriteLine(ConversaoDoDouble);

            int NumeroGrande = 1000;
            byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            Console.WriteLine(NumeroPequeno);





            Console.ReadKey();
        }
    }
}

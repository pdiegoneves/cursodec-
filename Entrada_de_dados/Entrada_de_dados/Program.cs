﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Olá " + Nome);

            Console.WriteLine("Digite a sua idade:");
            string Idade = Console.ReadLine();
            Console.WriteLine("Você tem " + Idade + " anos de idade.");
            int IdadeInt = Convert.ToInt32(Idade);

            Console.WriteLine("Pressine qualquer tecla:");
            char TeclaPressionada = Console.ReadKey(true).KeyChar;
            string TeclaPressionadaString = Console.ReadKey(true).KeyChar.ToString();
            string TeclaPressionadaString2 = Convert.ToString(Console.ReadKey(true).KeyChar);
            Console.WriteLine("A tecla que você pressionou foi: " + TeclaPressionada);

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    internal class Program
    {
        enum NotasDeReal_e
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10,
        };
        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.NotaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota));
            Console.ReadKey();
        }
    }
}

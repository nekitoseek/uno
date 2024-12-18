using ModelUno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var count = PurchaseDesk.CardsCount();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShagovoyVV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ShagovoyVV.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substract(15, 5));
            Console.WriteLine(DataService.Mplicate(10, 10));
            Console.WriteLine(DataService.division(5, 5));
            Console.ReadKey();
        }
    }
}

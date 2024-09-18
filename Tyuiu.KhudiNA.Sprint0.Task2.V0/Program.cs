using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhudiNA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KhudiNA.Sprint0.Task2.V0
{
    internal class Program
    {
        private static object DataService;

        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.KhudiNA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Наталья"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

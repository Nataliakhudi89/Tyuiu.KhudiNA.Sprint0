using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KhudiNA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            //Пример циклической структуры находится в библиотеке классов в методе AditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AddittionArray(numsAray));

            //Пример циклической структуры находится в библиотеке классов в методе SubtractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

            //Пример циклической структуры находится в библиотеке классов в методе MultiolicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MulyiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}

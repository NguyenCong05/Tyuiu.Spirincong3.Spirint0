using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.Spirincong3.Spirint0.Task3.V0.Lib;

namespace Tyuiu.Spirincong3.Spirint0.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.SpirinIS.Sprint0.Task2.V0.Lib 
            Console.WriteLine(DataService.Sum(7, 7));
            Console.ReadKey();
        }
    }
}

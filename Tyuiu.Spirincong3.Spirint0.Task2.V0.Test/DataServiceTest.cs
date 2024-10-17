using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Spirincong3.Spirint0.Task2.V0.Lib;

namespace Tyuiu.Spirincong3.Spirint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Конг";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Конг", res);
        }
    }
}

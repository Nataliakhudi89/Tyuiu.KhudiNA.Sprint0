﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhudiNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhudiNA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
                var name = "Наталья"
                var res = DataService.GetMessage(name);
            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Наталья", res);

        }
    }
}

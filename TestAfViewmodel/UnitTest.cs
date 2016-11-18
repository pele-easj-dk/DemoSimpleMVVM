using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using DemoSimpleMVVM.viewmodel;

namespace TestAfViewmodel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainViewModel mvm = new MainViewModel();
            int carsSize = mvm.Common.Liste.Count;
            
            mvm.Sometext = "ZZ23456";
            mvm.CreateCar();

            Assert.AreEqual(carsSize+1, mvm.Common.Liste.Count);
        }

    }
}

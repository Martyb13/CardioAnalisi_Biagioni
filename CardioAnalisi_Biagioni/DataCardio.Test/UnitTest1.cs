using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double età = 90;
            double min = 0;
            double risultato_atteso = 117;
            double risultato_atteso2 = 91;
            double risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza(età, ref min);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
            Assert.AreEqual(min, risultato_atteso2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double età = 16;
            double min = 0;
            double risultato_atteso = 183.6;
            double risultato_atteso2 = 142.8;
            double risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza(età, ref min);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
            Assert.AreEqual(min, risultato_atteso2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double età = 35;
            double min = 0;
            double risultato_atteso =166.5;
            double risultato_atteso2 = 129.5;
            double risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza(età, ref min);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
            Assert.AreEqual(min, risultato_atteso2);
        }
    }
}

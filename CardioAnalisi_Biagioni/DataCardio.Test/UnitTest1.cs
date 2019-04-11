using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFrequenza()
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
        public void TestFrequenza2()
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
        public void TestFrequenza3()
        {
            double età = 35;
            double min = 0;
            double risultato_atteso =166.5;
            double risultato_atteso2 = 129.5;
            double risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza(età, ref min);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
            Assert.AreEqual(min, risultato_atteso2);
        }
        [TestMethod]
        public void TestCondizioni()
        {
            int battiti = 60;
            string risultato_atteso = "Normale";
            string risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Condizioni(battiti);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestCondizioni2()
        {
            int battiti = 49;
            string risultato_atteso = "Bradicardia";
            string risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Condizioni(battiti);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestCondizioni3()
        {
            int battiti = 150;
            string risultato_atteso = "Tachicardia";
            string risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Condizioni(battiti);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
        [TestMethod]
        public void TestCondizioni4()
        {
            int battiti = -5;
            string risultato_atteso = "Errore!!";
            string risultato_ottenuto = CardioAnalisiLibrary.DataCardio.Condizioni(battiti);
            Assert.AreEqual(risultato_atteso, risultato_ottenuto);
        }
    }
}

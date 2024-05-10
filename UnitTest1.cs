using net_calculator_tester;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void TestSomma()
        {
            
            float result = Calcolatrice.Somma(5, 3);
            Assert.AreEqual(8, result);

        }
        [Test]
        public void TestDifferenza()
        {
            float result = Calcolatrice.Differenza(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestProdotto()
        {
            float result = Calcolatrice.Prodotto(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void TestDivisione()
        {
            float result = Calcolatrice.Divisione(5, 5);
            Assert.AreEqual(1, result);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorGenerator;

namespace Test
{
    [TestClass]
    public class PrimeFactorTest
    {
        private static List<int> MakeList(params int[] ints)
        {
            return ints.ToList();
        }

        [TestMethod]
        public void Test1()
        {
            CollectionAssert.AreEqual(MakeList(), PrimeFactors.Generate(1));
        }

        [TestMethod]
        public void Test2()
        {
            CollectionAssert.AreEqual(MakeList(2), PrimeFactors.Generate(2));
        }

        [TestMethod]
        public void Test3()
        {
            CollectionAssert.AreEqual(MakeList(3), PrimeFactors.Generate(3));
        }

        [TestMethod]
        public void Test4()
        {
            CollectionAssert.AreEqual(MakeList(2, 2), PrimeFactors.Generate(4));
        }

        [TestMethod]
        public void Test6()
        {
            CollectionAssert.AreEqual(MakeList(2, 3), PrimeFactors.Generate(6));
        }

        [TestMethod]
        public void Test8()
        {
            CollectionAssert.AreEqual(MakeList(2, 2, 2), PrimeFactors.Generate(8));
        }

        [TestMethod]
        public void Test9()
        {
            CollectionAssert.AreEqual(MakeList(3, 3), PrimeFactors.Generate(9));
        }
    }
}

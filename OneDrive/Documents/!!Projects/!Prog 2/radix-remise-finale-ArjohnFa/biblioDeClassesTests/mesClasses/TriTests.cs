using Microsoft.VisualStudio.TestTools.UnitTesting;
using biblioDeClasses.mesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioDeClasses.mesClasses.Tests
{
    [TestClass]
    public class TriTests
    {
        [TestMethod]
        public void RadixTest()
        {
            //arranger
            int[] tableau = { 2, 787, 45, 100, 50, 682, 547 };
            int[] bontab = { 2, 45, 50, 100, 547, 682, 787 };


            //act

            Tri.Radix(tableau);



            //assert

            for(int i = 0; i < tableau.Length; i++)
            {
                Assert.AreEqual(tableau[i], bontab[i]);
            }
        }
    }
}
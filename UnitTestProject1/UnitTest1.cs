using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teszt;
using System;
using System.IO;

namespace Teszt_UnitTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartEredm = "Helló Cigány!";

            using (var SW = new StringWriter())
            {
                Console.SetOut(SW);
                Program.Main();
                var kapottErdm = SW.ToString().Trim();

                Assert.AreEqual(vartEredm, kapottErdm);
            }
        }
    }
}

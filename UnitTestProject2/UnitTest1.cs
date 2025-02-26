using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;

namespace AtvaltOOP
{
    [TestClass]
    public class Atvalt
    {
        Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void isDecimal_True()
        {
            string szoveg = "21";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isDecimal_False()
        {
            string szoveg = "!";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]

        public void iSbinar_true()
        {
            string szoveg = "01010101";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);

        }
        [TestMethod]
        public void iSbinar_false()
        {
            string szoveg = "!";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        private bool isDecimal(string szoveg)
        {
            throw new NotImplementedException();
        }

        public void iSdecimal_False2() {

            string szoveg = "0110";
            bool vartEredm = false,
            kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }


    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KorTDD;

namespace KorTDDTeszt
{
    [TestClass]
    public class KorClassTeszt
    {
        KorClass kor = new KorClass(4.0);

        [TestMethod]
        public void SetKerulet_teszt_True()
        {

            double sugar = kor.getSugar();
            double vartEredm = 25.12,
                kapottEredm;

            kapottEredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void SetKerulet_teszt_False()
        {

            double sugar = kor.getSugar();
            double vartEredm = 25.11,
                kapottEredm;

            kapottEredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void SetKerulet_teszt_False_felett()
        {

            double sugar = kor.getSugar();
            double vartEredm = 25.13,
                kapottEredm;

            kapottEredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }


        [TestMethod]

        public void SetTerulet_teszt_True()
        {
            double sugar = kor.getSugar();
            double vartEredm = 50.24,
                kapottEredm;

            kapottEredm=kor.setTerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]

        public void SetTerulet_teszt_False()
        {
            double sugar = kor.getSugar();
            double vartEredm = 50.23,
                kapottEredm;

            kapottEredm = kor.setTerulet(sugar);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}

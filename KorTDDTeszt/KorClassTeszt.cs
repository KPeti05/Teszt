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

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void setKerulet_teszt_False_Alatt()
        {
            //Arange
            kor.setSugar(0);
            double sugar = kor.getSugar();
            double vartEredm = 25.11,
                kapottEredm;


            //Act
            kapottEredm = kor.setKerulet(sugar);

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);

        }
        [TestMethod]
        public void setKerulet_teszt_False_Felett()
        {
            //Arange
            double sugar = kor.getSugar();
            double vartEredm = 25.13,
                kapottEredm;


            //Act
            kapottEredm = kor.setKerulet(sugar);

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);

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

            Assert.AreNotEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void setTerulet_teszt_False_alatta()
        {
            //Arange 
            double sugar = kor.getSugar();
            double vartEredm = 50.23,
                kapottEredm;

            //Act
            kapottEredm = kor.setTerulet(sugar);

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);

        }
        [TestMethod]
        public void setTerulet_teszt_False_felett()
        {
            //Arange 
            double sugar = kor.getSugar();
            double vartEredm = 50.25,
                kapottEredm;

            //Act
            kapottEredm = kor.setTerulet(sugar);

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);

        }
        [TestMethod]
        public void setSugar_teszt()
        {
            //Arange
            double sugar = kor.getSugar();
            double vartEredm = 4.0
                , kapottEredm;

            //Act
            kapottEredm = kor.getSugar();

            //Assert
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void setSugar_teszt_false_alatt()
        {
            //Arange
            double sugar = kor.getSugar();
            double vartEredm = 3.9
                , kapottEredm;

            //Act
            kapottEredm = kor.getSugar();

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void setSugar_teszt_false_felett()
        {
            //Arange
            double sugar = kor.getSugar();
            double vartEredm = 4.1
                , kapottEredm;

            //Act
            kapottEredm = kor.getSugar();

            //Assert
            Assert.AreNotEqual(kapottEredm, vartEredm);
        }
    }
}

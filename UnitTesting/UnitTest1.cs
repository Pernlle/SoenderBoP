using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoenderBoP;

namespace UnitTesting 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1CreateNavn()
        {
            Create s = new Create();
            s.GetFNameTxt = "navn";
            Assert.AreEqual("", s.GetFNameTxt);
            //s=
            ////Assert.Pass(); //skal være rigtigt (pass=gør intet?)
            //Assert.AreEqual(1000, kunde.Getpostnummer);
        }
        [TestMethod]
        public void Test2CreateNotNavn()
        {
            Create s = new Create();
            s.GetFNameTxt = "navn";
            Assert.AreNotEqual("navn", s.GetFNameTxt);

            //kunde.Setpostnummer = 2000000;
            ////Assert.Pass(); //skal være rigtigt (pass=gør intet?)
            //Assert.AreNotEqual(2000000, kunde.Getpostnummer);
        }
        [TestMethod]
        public void TestMethod3()
        {

        }
        [TestMethod]
        public void TestMethod4()
        {

        }
    }
}

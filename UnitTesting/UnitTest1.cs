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
            //Create s = new Create();
            //s.GetFNameTxt = "navn";
            //Assert.AreEqual("", s.GetFNameTxt);
            //s=
            ////Assert.Pass(); //skal være rigtigt (pass=gør intet?)
            //Assert.AreEqual(1000, kunde.Getpostnummer);
            //Database strConnProvider = new Database();
            //Print print = new Print();


        }
       
        [TestMethod]
        public void TestCRUDCreateMethod()
        {
            string t = "0";
            string t1 = "1";
            string t2 = "2";
            string t3 = "3";
            string n = "Medlem";

            string[] s = { t, t1, t2, t3 };
            string a= t + "," + t1 + "," + t2 + "," + t3;

            CRUD.Create(n,a,s);
            //Great success
        }
        [TestMethod]
        public void TestCRUDDeleteMethod()
        {
            string n = "Venteliste";
            string w = "vMId=9";


            CRUD.Delete(n, w);
            
        }
    }
}

using EserciziStringhe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testesStringhe
{
    [TestClass]
    public class Teststringhe
    {
        [DataTestMethod]
        [DataRow("cane","elefante",0)]
        public void TestAreEuqal(string s1,string s2,int asp )
        {
            int risp = EsStringhe.AreEqual(s1, s2);
            Assert.AreEqual(asp, risp);
        }

        [DataTestMethod]
        [DataRow("cane",false)]
        public void TestContainsDoubleChar(string s1,bool asp)
        {
            bool risp = EsStringhe.ContainsDoubleChar(s1);
            Assert.AreEqual(asp, risp);
        }
        [DataTestMethod]
        [DataRow("cAnE","Cane")]
        public void TestConvert(string s1, string asp)
        {
            string risp = EsStringhe.Convert(s1);
            Assert.AreEqual(asp, risp);
        }

    }
}

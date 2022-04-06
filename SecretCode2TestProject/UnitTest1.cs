using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecretCode2;
using System;

namespace SecretCode2TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecrypt1()
        {
            string code = "6,12,9,10 9,10 3 6,18,10,6";
            string result = Collaboro.Decrypt(code);

            Assert.AreEqual("THIS IS A TEST", result);
        }

        [TestMethod]
        public void TestDecrypt2()
        {
            string code = "6,12,9,10 9,10 3 6,18,10,6,A";
            
            Assert.ThrowsException<FormatException>(() => Collaboro.Decrypt(code));
        }
    }
}

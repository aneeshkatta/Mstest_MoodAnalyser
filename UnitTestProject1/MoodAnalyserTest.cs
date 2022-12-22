using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mstest_Batch222;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {   
        //arrange  
        [DataRow("", "Empty mood Entered-invalid mood")]
        [TestMethod]
        public void GivenMessageShouldReturnSad(string messageinput, string expected)
        {
            MoodAnalyser obj = new MoodAnalyser(messageinput);
            //act
            string actual = obj.AnalyseMood();
            //assert
            Assert.AreEqual(actual, expected);//checking whether exception message is coming in output of analyse mood method for null input 
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mstest_Batch222;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {  //arrange  
        [DataRow(null,"HAPPY")]
        [TestMethod]
        public void GivenMessageShouldReturnSad(string messageinput,string expected)
        {
          
        }
    }
}

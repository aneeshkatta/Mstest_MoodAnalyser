using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mstest_Batch222;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    { 
        //arrange  
        [TestMethod]
        [DataRow("I am in HAPPY Mood","SAD")]//input given
        public void GivenMessageShouldReturnSad(string messageinput,string expected)
        {   
           
        }
    }
}

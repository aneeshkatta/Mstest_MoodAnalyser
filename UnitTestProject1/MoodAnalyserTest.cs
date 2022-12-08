using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mstest_Batch222;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {  //arrange  
        [TestMethod]
        [DataRow("I am in Sad Mood","sad")]//input given
        public void GivenMessageShouldReturnSad(string messageinput,string expected)
        {   
            MoodAnalyser obj = new MoodAnalyser();
            //act
            string actual=obj.AnalyseMood(messageinput);
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}

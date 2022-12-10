using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mstest_Batch222;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {  //arrange  
        [TestMethod]
        [DataRow("I am in Sad Mood","SAD")]//input given
        public void GivenMessageShouldReturnSad(string messageinput,string expected)
        {   
            MoodAnalyser obj = new MoodAnalyser(messageinput);
            //act
            string actual=obj.AnalyseMood();
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}

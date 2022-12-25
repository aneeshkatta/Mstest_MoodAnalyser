using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Mstest_Batch222;
using System.Security.Claims;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class MoodAnalyserTest
    {
        public MoodAnalyserFactory moodAnalyserFactory;
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("Mstest-Batch222.MoodAnalyser", "MoodAnalyser")] //TC 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        public void TC4_1_When_GivenClassInfo_Then_ReturnDefaultConstructor(string className, string constructorName)
        {
            moodAnalyserFactory = new MoodAnalyserFactory();
            object expectedObj = new MoodAnalyser();
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            actualObj.Equals(expectedObj);   //comparing two objects ,if found Equal than test will be passed .
        }
        [TestMethod]
        [TestCategory("Reflection")]//T.C 4.2 wrong classname input
        [DataRow("MstestBatch222.MoodAnalyser", "MoodAnalyser")] //Given Class Name When Improper Should Throw MoodAnalysisException//
        public void TC4_2_GivenClassNameWhenImproperShouldThrowMoodAnalysisException(string className, string constructorName)
        {
            moodAnalyserFactory = new MoodAnalyserFactory();
            object expectedObj = new MoodAnalyser();
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            try
            {
                actualObj.Equals(expectedObj);
            }
            catch (Exception e)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "NO_SUCH_METHOD");
            }
        }

        //UC4- TC4.3 : Given Class When  Constructor Not Proper Should Throw  MoodAnalysisException 
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("Mstest-Batch222.MoodAnalyser", "MoodAalyser")] // TC4.3 :wrong input of constructor
        public void TC4_3_When_GivenClassName_Then_Return_NoSuchMethodError(string className, string constructorName)
        {
            object expected = new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "NO_SUCH_METHOD");
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            try
            {
                actualObj.Equals(expected);
            }
            catch (Exception e)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "NO_SUCH_METHOD");
            }
            Equals(actualObj, expected);
        }
        /// <summary>
        ///  UC5 - Reflection
        ///  TC 5.1 Given Mood Analyser when class name with parameterized constructor should return object
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("Mstest-Batch222.MoodAnalyser", "MoodAnalyser", "Happy")]
        public void TC5_1_GivenMoodAnalyzer_WhenClassName_ShouldReturnMoodAnalyzerObjectUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            object expected =new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyzerUsingParameterizedConstructor(className, constructorName, message);
           Equals(expected,obj);
        }
        /// <summary>
        ///  UC5 - Reflection
        ///  TC 5.2 Given Mood Analyser when class name with parameterized constructor.
        ///  If class name is not propper then - return No such class error message
        ///  MoodAnalyser <<- this is for class
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void TC_5_2_GivenMoodAnalyzer_WhenClassNameNotPropper_ShouldReturn_NoSuchClassError()
        {
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyzerUsingParameterizedConstructor("Mstest-Batch222.WrongClass", "MoodAnalyzer", "Happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Equals(expected, exception.Message);
            }
        }
        /// <summary>
        ///  UC5 - Reflection
        ///  TC 5.3 Given Mood Analyser when class name with parameterized constructor.
        ///  If constructor name is not propper then - return No such Method error message
        ///  MoodAnalyser <<- this is for class
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void TC_5_3_GivenMoodAnalyzer_WhenConstructorNameNotPropper_ShouldReturn_NoSuchMethodError()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyzerUsingParameterizedConstructor("Mstest-Batch222.MoodAnalyser", "WrongConstructor", "Happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Equals(expected, exception.Message);
            }
        }
    }
}

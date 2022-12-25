using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    public class MoodAnalyserFactory
    {
        //UC4 CreatingMoodAnalyserObject() to get Object of MoodAnalyser class .
        public object CreatingMoodAnalyserObject(string className, string constructorName)
        {
            string pattern = "." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executingAssembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = executingAssembly.GetType(className);
                    //Type moodAnalyserType = Type.GetType("Mstest_Batch222.MoodAnalyser");
                    return Activator.CreateInstance(moodAnalyserType);
                    Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Your input is not valid");
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong happened.");
                    Console.WriteLine(e.Message);
                }
                return null;
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "No Such Method");
            }
        }
        public static object CreateMoodAnalyzerUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = Type.GetType("Mstest_Batch222.MoodAnalyser");
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}

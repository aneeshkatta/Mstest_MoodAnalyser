using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = "I am in Any mood";
            MoodAnalyser obj1 = new MoodAnalyser(message);
            obj1.AnalyseMood();
            Console.ReadKey();
        }
    }
}

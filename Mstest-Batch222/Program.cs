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
            string message = null;
            MoodAnalyser obj1 = new MoodAnalyser(message);
            Console.WriteLine(obj1.AnalyseMood());//returns output  value
            Console.ReadKey();
        }
    }
}

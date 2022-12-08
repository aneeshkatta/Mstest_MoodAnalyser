using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    public class Program
    {
        static void Main(string[] args)
        {
            string message = "im in sad mood";
            MoodAnalyser obj1 = new MoodAnalyser();
            obj1.AnalyseMood(message);
            Console.ReadKey();
        }
    }
}

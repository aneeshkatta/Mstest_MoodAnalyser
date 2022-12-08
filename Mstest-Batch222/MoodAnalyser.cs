using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.Equals(string.Empty))
            {
                return "Mood should not be empty";
            }
            if (message.ToLower().Contains("sad"))
            {
                Console.WriteLine("sad");
                return "sad";               
            }
            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }     
        }
    }
}

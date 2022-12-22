using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {

        }
        public string AnalyseMood()
        {
            if (this.message != null)
            {
                if (this.message.Equals(string.Empty))
                {
                    try
                    {
                        throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Empty mood Entered-invalid mood");
                    }
                    catch (MoodAnalyserCustomException ex)
                    {
                        return ex.Message;
                    }                  
                    return "Mood should not be empty";
                }

                if (this.message.ToLower().Contains("sad"))
                {
                      return "SAD";
                }
                else
                {
                      return "HAPPY";
                }
            }
            else
            {
                try
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_Message, "Invalid mood-null mood Entered");                  
                }
                catch (MoodAnalyserCustomException ex)
                {
                    return ex.Message;
                }
                finally
                {
                    Console.WriteLine("Exception is handled ! This Code is executed irrespective of Exception occured ");
                }
            }
        }
    }
}

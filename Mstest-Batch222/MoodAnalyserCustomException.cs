using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    internal class MoodAnalyserCustomException:Exception
    {
        private  ExceptionType exceptiontype;
        public enum ExceptionType
        {
            Null_Message,
            Empty_Message,
        }
        public MoodAnalyserCustomException(ExceptionType type, String message) : base(message)
        {
            this.exceptiontype = type;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Mstest_Batch222
{
    public class MoodAnalyserCustomException:Exception
    {
        public  ExceptionType exceptiontype;
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            CONSTRUCTOR_NOT_FOUND
        }
        public MoodAnalyserCustomException(ExceptionType type, String message) : base(message)
        {
            this.exceptiontype = type;
        }
        
    }
}

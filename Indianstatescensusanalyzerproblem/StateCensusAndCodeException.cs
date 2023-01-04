using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indianstatescensusanalyzerproblem
{
    public class StateCensusAndCodeException : Exception
    {
        public enum ExceptionType
        {
            
        }
        public ExceptionType Type;
        public StateCensusAndCodeException(ExceptionType exceptionType, string message) : base(message)
        {
            Type = exceptionType;
        }
    }
}
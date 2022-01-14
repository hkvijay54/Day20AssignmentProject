using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Assignment
{
    public class CustomExceptions:Exception
    {
        public enum exType
        {
            NULL_MSG,
            EMPTY_MSG,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_PARAMETER,
            NO_SUCH_TYPE,
            NO_SUCH_EXCEPTION,
            NO_SUCH_METHOD_EXCEPTION,
            NULL_VALUE,
            NO_SUCH_FIELD
        }

        private readonly exType type;

        public CustomExceptions(exType type, string message):base(message)
        {
            this.type = type;
        }
    }
}

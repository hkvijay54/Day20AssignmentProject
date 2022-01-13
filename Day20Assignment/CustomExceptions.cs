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
            EMPTY_MSG
        }

        private readonly exType type;

        public CustomExceptions(exType type, string message):base(message)
        {
            this.type = type;
        }
    }
}

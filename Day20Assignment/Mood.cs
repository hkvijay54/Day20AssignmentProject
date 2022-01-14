using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day20Assignment
{
    public class Mood
    {
        private string msg;
        public Mood()
        {
            this.msg = null;
        }
        public Mood(string msg)
        {
            this.msg = msg;
        }
        public string Analysis()
        {
            try
            {
                if (this.msg.Equals(string.Empty))
                {
                    throw new CustomExceptions(CustomExceptions.exType.EMPTY_MSG, "String should not be empty");
                }

                if (this.msg.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
                throw new CustomExceptions(CustomExceptions.exType.NULL_MSG, "String should not be null");
            }
        }
    }
}
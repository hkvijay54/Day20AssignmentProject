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

        public Mood(string msg)
        {
            this.msg = msg;
        }

        public string Analysis()
        {
            if (this.msg.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}
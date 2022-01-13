using System;


namespace Day20Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1
            Mood m1 = new Mood("SAD");
            string msg = m1.Analysis();
            Console.WriteLine(msg);
        }
    }
}
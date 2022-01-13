using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Day20Assignment
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string cnstrName)
        {
            string pattern = @"." + cnstrName + "$";
            Match res = Regex.Match(className, pattern);
            if (res.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentException)
                {
                    throw new CustomExceptions(CustomExceptions.exType.NO_SUCH_CLASS, "Class not exists");
                }
            }
            else
            {
                throw new CustomExceptions(CustomExceptions.exType.NO_SUCH_METHOD, "cONSTRUCTOR NOT EXISTS");
            }
        }
    }
}

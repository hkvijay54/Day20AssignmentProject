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
                throw new CustomExceptions(CustomExceptions.exType.NO_SUCH_METHOD, "CONSTRUCTOR NOT EXISTS");
            }
        }

        public static object CreateMoodAnalyserParaCnstr(string classname, string cnstrname, string message)
        {
            Type type = typeof(Mood);
            if(type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if(type.Name.Equals(cnstrname))
                {
                    ConstructorInfo c = type.GetConstructor(new[] {typeof(string)});
                    object instance = c.Invoke(new object[] {message});
                    return instance;
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.exType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new CustomExceptions(CustomExceptions.exType.NO_SUCH_CLASS, "Class not found");
            }
        }

        public static string MoodInvokeAnalyse(string message, string methodName)
        {
            try
            {
                Type type = typeof(Mood);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserParaCnstr("DAy20Assignment.Mood", "Mood", message);
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();
            }

            catch (NullReferenceException)
            {
                throw new CustomExceptions(CustomExceptions.exType.NULL_VALUE, "method not found");
            }
        }

    }
}

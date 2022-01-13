using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20Assignment;

namespace TestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1MoodAnalyserObj()
        {
            string msg = null;
            object exp = new Mood(msg);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20Assignment.Mood", "Mood");
            exp.Equals(obj);
        }
        [TestMethod]
        public void TestMethod1MoodAnalyserWrongObj()
        {
            try
            {
                string msg = null;
                object exp = new Mood(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20Assignment.MoodWrong", "Mood");
                exp.Equals(obj);
            }
            catch(CustomExceptions ex)
            {
                Assert.AreEqual("class not found", ex.Message);
            }
           
        }
        [TestMethod]
        public void TestMethod1MoodAnalyserWrongCnstrObj()
        {
            try
            {
                string msg = null;
                object exp = new Mood(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20Assignment.Mood", "MoodWrong");
                exp.Equals(obj);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("class not found", ex.Message);
            }

        }
    }
}
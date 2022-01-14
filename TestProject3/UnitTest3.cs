using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20Assignment;

namespace TestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void ReturnMoodAnalyseParameterizedConstructor()
        {
            object expected = new Mood("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserParaCnstr("Day20Assignment.Mood", "Mood", "HAPPY");
            expected.Equals(obj);
        }

        [TestMethod]
        public void ImproperClassNameMoodAnalysisExceptionParameterizedConstructor()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserParaCnstr("Day20Assignment.WrongClass", "Mood", "HAPPY");
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void ImproperConstructorNameMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserParaCnstr("Day20Assignment.Mood", "WrongConstructor", "HAPPY");
            }
            catch (CustomExceptions exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
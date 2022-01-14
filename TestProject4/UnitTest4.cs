using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20Assignment;

namespace TestProject4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void ReturnHappyMoodUsingReflectorInvoke()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.MoodInvokeAnalyse("HAPPY", "Analysis");
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void ImproperMethodMoodAnalysisExceptionHappy()
        {
            try
            {
                string expected = "method not found";
                string mood = MoodAnalyserFactory.MoodInvokeAnalyse("HAPPY", "AnalyseWrong");
                Assert.AreNotEqual(expected, mood);
            }

            catch (CustomExceptions ex)
            {
                Assert.AreEqual("method not found", ex.Message);
            }
        }
    }
}
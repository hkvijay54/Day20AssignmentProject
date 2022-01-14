using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20Assignment;

namespace TestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReflectorDynamically()
        {
            string result = MoodAnalyserFactory.DynamicFeild("HAPPY", "msg");
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void WrongFieldException()
        {
            try
            {
                string result = MoodAnalyserFactory.DynamicFeild("HAPPY", "msgWrong");
                Assert.AreEqual("HAPPY", result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("Field not Found", ex.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMessageShouldReturnException()
        {
            try
            {
                string result = MoodAnalyserFactory.DynamicFeild(null, "message");
                Assert.AreEqual("Happy", result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20Assignment;
namespace TestProject1
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestMethod1SAD()
        {
            string exp = "SAD";
            string msg = "I m SAD";
            Mood m1 = new Mood(msg);

            string mood = m1.Analysis();

            Assert.AreEqual(exp, mood);
        }

        [TestMethod]
        public void TestMethod2HAPPY()
        {
            string exp = "HAPPY";
            string msg = "I m happy";
            Mood m1 = new Mood(msg);

            string mood = m1.Analysis();

            Assert.AreEqual(exp, mood);
        }

    }
}
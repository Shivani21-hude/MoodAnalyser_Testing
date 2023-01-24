using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyzer analyse = new MoodAnalyzer();
            string actualResult = analyse.Analyze("Happy");
            Assert.AreEqual("Happy", actualResult);
        }
    }
}
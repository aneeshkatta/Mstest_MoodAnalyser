namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public MoodAnalyser obj = new MoodAnalyser();
        string expected = "Happy";

        string message = "my mood is Happy";

        string mood = obj.analyseMood(message);
        Assert.AreEqual(expected, mood);
        }
}

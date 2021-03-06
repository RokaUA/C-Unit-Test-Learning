using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingSamples.MSTests
{
    [TestClass]
    public class DeepThoughtTest
    {
        [TestMethod]
        public void ResultOfTheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything()
        {
            // arrange
            int expected = 42;
            var dt = new DeepThought();

            // act
            int actual = dt.TheAnswerOfTheUltimateQuestionOfLifeTheUniverseAndEverything();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

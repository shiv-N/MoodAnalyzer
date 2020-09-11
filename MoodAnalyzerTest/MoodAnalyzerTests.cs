using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class MoodAnalyzerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// TC 1.1: Given “I am in Sad Mood” message Should Return SAD.
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }

    }
}
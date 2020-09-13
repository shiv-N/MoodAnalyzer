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
        /// TC 1.1: Given �I am in Sad Mood� message Should Return SAD.
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC 1.2: Given �I am in Any Mood� message Should Return HAPPY
        /// </summary>
        [Test]
        public void GivenHAPPYMoodShouldReturnHappy()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC 2.1: Given null mood Should Return HAPPY
        /// </summary>
        [Test]
        public void GivenNullMoodShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            string message = null;
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
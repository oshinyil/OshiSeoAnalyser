using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OshiSeoAnalyser.Core.Test
{
    [TestClass]
    public class SeoAnalyserTests
    {
        [TestMethod]
        public void Analyse_GivenText_ReturnsWordOccurences()
        {
            const string rawText = "I love you but I hate you. I really love you.";

            var wordOccurences = SeoAnalyser.Analyse(rawText);

            Assert.AreEqual(2, wordOccurences["love"]);
            Assert.AreEqual(1, wordOccurences["hate"]);
            Assert.IsFalse(wordOccurences.ContainsKey("you"));
        }

        [TestMethod]
        public void Analyse_GivenEmptyString_ReturnsEmptyDictionary()
        {
            const string rawText = "";

            var wordOccurences = SeoAnalyser.Analyse(rawText);
            
            Assert.AreEqual(0, wordOccurences.Count);
        }
    }
}

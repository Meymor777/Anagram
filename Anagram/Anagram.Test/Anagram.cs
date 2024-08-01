namespace Anagram.Test
{
    using Anagram.BL;
    using Anagram.Types;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        internal class AnagramTest
        {
            [TestCase("abcd efgh", "dcba hgfe")]
            [TestCase("a1bcd efg!h", "d1cba hgf!e")]
            [TestCase(" a1bcd efg!h", " d1cba hgf!e")]
            [TestCase("Test", "tseT")]
            public void TestOrdinaryVariant(string text, string result)
            {
                Assert.AreEqual(result, Anagram.ReverseText(text));
            }

            [Test]
            public void TestOnlySpace()
            {
                Assert.AreEqual("   ", Anagram.ReverseText("   "));
            }

            [Test]
            public void TestEmptyString()
            {
                Assert.AreEqual("", Anagram.ReverseText(""));
            }

            [Test]
            public void TestOnlyNotAlphabetic()
            {
                Assert.AreEqual("012345", Anagram.ReverseText("012345"));
            }

            [Test]
            public void TestNullString()
            {
                Assert.Throws<InvalidParameterException>(() =>
                {
                    Anagram.ReverseText(null);
                });
            }
        }
    }
}
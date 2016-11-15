using NUnit.Framework;

using SkeletonCode.ReversingString;

namespace UnitTests.ReversingString
{
	[TestFixture]
	public class StringUtiltiesTests
	{
		[TestCase("", "")]
		[TestCase("skeleton", "noteleks")]
		[TestCase(null, "")]
		public void ReverseStringShouldReturnTheStringInTheReverseOrder(string input, string expectedResult)
		{
			StringUtilities stringUtilities = new StringUtilities();
			string result = stringUtilities.Reverse(input);

			Assert.AreEqual(expectedResult, result);
		}

        [Test]
        public void ReverseUnicodeStringShouldReturnTheStringInTheReverseOrder()
        {
            const string input = "Räksmörgås";
            const string expected = "sågrömskäR";

            StringUtilities stringUtilities = new StringUtilities();
            string result = stringUtilities.Reverse(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase("orangebus")]
        [TestCase("skeleton")]
        [TestCase("OrangeBus")]
        [TestCase("Räksmörgås")]
        public void DoubleReverseStringShouldReturnTheOriginalString(string input)
        {
            StringUtilities stringUtilities = new StringUtilities();

            string result = stringUtilities.Reverse(stringUtilities.Reverse(input));

            Assert.AreEqual(input, result);
        }
	}
}

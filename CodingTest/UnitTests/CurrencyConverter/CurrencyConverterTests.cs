using NUnit.Framework;
using SkeletonCode.CurrencyConverter;

namespace UnitTests.CurrencyConverter
{
	[TestFixture]
	public class CurrencyConverterTests
	{
		[Test]
		public void ItShouldConvertFromPoundsToDollarsCorrectly()
		{
			const decimal amountInPounds = 1m;
			const decimal expectedAmountInDollars = 1.25m;

			Converter converter = new Converter();
			decimal result = converter.Convert("GBP", "USD", amountInPounds);

			Assert.AreEqual(expectedAmountInDollars, result);
		}

		[Test]
		public void ItShouldConvertFromDollarsToPoundsCorrectly()
		{
			const decimal amountInDollars = 1m;
			const decimal expectedAmountInPounds = 0.8m;

			Converter converter = new Converter();
			decimal result = converter.Convert("USD", "GBP", amountInDollars);

			Assert.AreEqual(expectedAmountInPounds, result);
		}

        [Test]
        public void ItShouldConvertFromDollarsToDollarsCorrectly()
        {
            const decimal amountInDollars = 1m;

            Converter converter = new Converter();
            decimal result = converter.Convert("GBP", "GBP", amountInDollars);

            Assert.AreEqual(amountInDollars, result);
        }

        [Test]
        public void ItShouldConvertFromPoundsToPoundsCorrectly()
        {
            const decimal amountInPounds = 1m;

            Converter converter = new Converter();
            decimal result = converter.Convert("USD", "USD", amountInPounds);

            Assert.AreEqual(amountInPounds, result);
        }
		
		[Test]
		[ExpectedException()]
		public void AnExceptionShouldBeThrownIfAnUnknownCurrencyTypeIsPassedIn()
		{
			Converter converter = new Converter();
			converter.Convert("USD", "DDD", 100);
		}
	}
}

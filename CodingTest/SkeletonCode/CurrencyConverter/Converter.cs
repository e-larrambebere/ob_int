using System;
using System.Collections.Generic;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
    {
        private readonly IDictionary<Tuple<string, string>, decimal> _conversionRates =
               new Dictionary<Tuple<string, string>, decimal>
	        {
                {
	                new Tuple<string, string>("GBP", "USD"),
	                1.25M
	            },
                {
	                new Tuple<string, string>("USD", "GBP"),
	                0.8M
	            }
	        };

        public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(inputCurrency))
            {
                throw new ArgumentException("inputCurrency");
            }

            if (string.IsNullOrWhiteSpace(outputCurrency))
            {
                throw new ArgumentException("outputCurrency");
            }

            if (inputCurrency.Equals(outputCurrency, StringComparison.OrdinalIgnoreCase))
            {
                return amount;
            }

            var searchTuple = new Tuple<string, string>(inputCurrency, outputCurrency);

            if (!_conversionRates.ContainsKey(searchTuple))
            {
                throw new ArgumentException(
                    string.Format(
                        "There is no conversion defined between {0} and {1}.",
                        inputCurrency,
                        outputCurrency
                    )
                );
            }

            return _conversionRates[searchTuple] * amount;
        }
	}
}

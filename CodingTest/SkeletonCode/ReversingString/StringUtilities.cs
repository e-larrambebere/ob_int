using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            char[] inputAsCharArray = input.ToCharArray();
            Array.Reverse(inputAsCharArray);
            return new string(inputAsCharArray);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	public interface ICard
	{
        CardSuitEnum CardSuit { get; }

        CardValueEnum Value { get; }
	}
}

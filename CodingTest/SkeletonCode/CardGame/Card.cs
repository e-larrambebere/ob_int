
namespace SkeletonCode.CardGame
{
    public class Card : ICard
    {
        public CardSuitEnum CardSuit
        {
            get; 
            private set;
        }

        public CardValueEnum Value
        {
            get; 
            private set;
        }

        public Card(CardSuitEnum cardSuitEnum, CardValueEnum cardValueEnum)
        {
            CardSuit = cardSuitEnum;
            Value = cardValueEnum;
        }
    }
}

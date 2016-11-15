using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
    public class Default52PackOfCards : IPackOfCards
    {
        private Stack<ICard> _cardStack = new Stack<ICard>();

        public Default52PackOfCards()
        {
            foreach (CardValueEnum val in Enum.GetValues(typeof(CardValueEnum)))
            {
                foreach (CardSuitEnum suit in Enum.GetValues(typeof(CardSuitEnum)))
                {
                    _cardStack.Push(new Card(suit, val));
                }
            }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return _cardStack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get { return _cardStack.Count; }
        }

        public void Shuffle()
        {
            var list = _cardStack.ToList();

            var result = list.OrderBy(x => Guid.NewGuid());

            _cardStack = new Stack<ICard>(result);
        }

        public ICard TakeCardFromTopOfPack()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("There are no cards left.");
            }

            ICard cardRemoved = _cardStack.Pop();
            return cardRemoved;
        }
    }
}
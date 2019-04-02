using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    public class Output
    {
        public List<Card> MyCards { get; set; }

        public Output()
        {
            MyCards = new List<Card>()
            {
                new Card(TypeOfCard.Hearts, CardValue.Eight),
                new Card(TypeOfCard.Diamonds, CardValue.Eight),
                new Card(TypeOfCard.Diamonds, CardValue.Eight),
                new Card(TypeOfCard.Hearts, CardValue.Jack),
                new Card(TypeOfCard.Diamonds, CardValue.Jack),
            };
        }

        public bool OnePair
        {
            get
            {
                return MyCards
                    .GroupBy(p => p.NameOfCard)
                    .Where(p => p.Count() == 2)
                    .Count() == 1;
            }
        }

        public bool TwoPair
        {
            get
            {
                return MyCards
                    .GroupBy(p => p.NameOfCard)
                    .Where(p => p.Count() == 2)
                    .Count() == 2;
            }
        }

        public bool ThreeOfAKind
        {
            get
            {
                return MyCards
                    .GroupBy(p => p.NameOfCard)
                    .Where(p => p.Count() == 3)
                    .Count() == 1;
            }
        }

        //public bool Straight
        //{
        //    get
        //    {
        //        MyCards.Sort
        //    }
        //}

        public bool Flush
        {
            get
            {
                return MyCards
                    .GroupBy(p => p.TypeOfCard)
                    .Count() == 1;
            }
        }

        public bool FullHouse
        {
            get
            {
                return OnePair && ThreeOfAKind;
            }
        }

        public bool FourOfAKind
        {
            get
            {
                return MyCards
                    .GroupBy(p => p.NameOfCard)
                    .Where(p => p.Count() == 4)
                    .Count() == 1;
            }
        }

        //public bool StraightFlush
        //{
        //    get
        //    {

        //    }
        //}

        //public bool FiveOfAKind
        //{
        //    get
        //    {
        //        return 
        //    }
        //}
    }
}

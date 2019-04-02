using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    public class MyCards
    {
        public MyCards()
        {
            Cards = new List<Card>();
            foreach (var typeOfCard in Enum.GetValues(typeof(TypeOfCard)))
            {
                foreach (var nameOfCard in Enum.GetValues(typeof(CardValue)))
                {
                    var card = new Card((TypeOfCard)typeOfCard, (CardValue)nameOfCard);
                    
                    Cards.Add(card);
                }
            }
            Cards = Cards.OrderBy(p => Guid.NewGuid()).ToList();
        }

        public List<Card> Cards { get; set; }
    }
}

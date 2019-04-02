using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    public class Card
    {
        public TypeOfCard TypeOfCard { get; set; }
        public CardValue NameOfCard { get; set; }

        public Card(TypeOfCard typeOfCard, CardValue cardValue)
        {
            TypeOfCard = typeOfCard;
            NameOfCard = cardValue;
        }       
    }
}

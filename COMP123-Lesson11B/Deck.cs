using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 25, 2017
* Description: It inherits from the list generic and uses card as base type
* Version: 0.2 - added shuffle method
*/

namespace COMP123_Lesson11B
{
    public class Deck: List<Card>
    {
        //Private instance variables
        private Random _random;

        

        //Public properties

        //Constructor
        public Deck()
        {
            this._initialize();
        }

        /// <summary>
        /// This is the initialize method
        /// </summary>
        //Private Methods
        public void _initialize()
        {
            // Initialize the pseudo random number generator
            this._random = new Random();

            // This builds the deck - fills with cards
            for (int suit = (int)(Suit.Clubs); suit <= (int)(Suit.Spades); suit++)
            {
                for (int face = (int)(Face.Ace); face <= (int)(Face.King); face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }          
        }

        //Public Methods
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString; 
        }

        /// <summary>
        /// This methods shuffles the deck by using random indices to select two cards at a time
        /// It uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;


            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this._random.Next(0, 52);
                secondCard = this._random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();

                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
    }
}
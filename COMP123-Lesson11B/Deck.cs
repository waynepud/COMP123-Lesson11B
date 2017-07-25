using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 25, 2017
* Description: It inherits from the list generic and uses card as base type
* Version: 0.2 - Created the deck class
*/

namespace COMP123_Lesson11B
{
    public class Deck: List<Card>
    {
        //Private instance variables

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
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 0; face <= (int)Face.King; face++)
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
                outputString += "The " + card.Face + "of " + card.Suit + "\n";
            }

            return outputString; 
        }
    }
}
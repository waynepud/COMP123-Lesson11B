using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 27, 2017
* Description: This is the hand class
* Version: 0.2 - Added the highestcards method for lab assignmemnt
*/

namespace COMP123_Lesson11B
{
    public class Hand : CardList
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS


        //PRIVATE METHODS
        protected override void _initialize()
        {
            //STUB
            //This method is empty
        }

        //PUBLIC METHODS
        public override string ToString()
        {
            string outputString = "";
            outputString += ("======== Current Hand ========\n");
            outputString += ("===== Number of cards: " + this.Count + " ======\n");


            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void HighestCards(Hand hand)
        {
            var handSorted = from cards in hand orderby cards.Face descending select cards.Face;
            Console.WriteLine("=== The sorted hand values in descending order ===");
            foreach (var c in handSorted)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("");
            Console.WriteLine("=== The highest value cards ===");

            foreach (var item in handSorted)
            {
                if (item == handSorted.Max())
                {
                    Console.WriteLine(item);                       
                }
            }
        }
    }
}
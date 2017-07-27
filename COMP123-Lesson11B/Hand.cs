using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 27, 2017
* Description: This is the hand class
* Version: 0.1 - Created the hand class
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
            outputString += ("-------------Hand = Number of Cards:--------------");
            outputString += ("Number of cards: " + this.Count + "\n");


            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}
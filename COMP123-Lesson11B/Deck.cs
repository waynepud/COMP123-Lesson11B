using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 27, 2017
* Description: It inherits from the CardList Abstract class
* Version: 0.7 - Added deal5 method for 5 cards
*/

namespace COMP123_Lesson11B
{
    public class Deck : CardList
    {
        //Private instance variables
        private Random _random;



        //Public properties

        //Constructor


        /// <summary>
        /// This is the initialize method
        /// </summary>
        //Private Methods
        protected override void _initialize()
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
            outputString += ("Number of cards: " + this.Count + "\n");


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
                firstCard = this._random.Next(0, this.Count);
                secondCard = this._random.Next(0, this.Count);
                tempCard = (Card)this[secondCard].Clone();
                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);

                //this[secondCard].Face = this[firstCard].Face;
                //this[secondCard].Suit = this[firstCard].Suit;
                //this[firstCard].Face = tempCard.Face;
                //this[firstCard].Suit = tempCard.Suit;
            }
        }

        /// <summary>
        /// This method returns the top card of the deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            
            Card topCard = this[0];
            this.RemoveAt(0); //this removes the top card from the deck

            // for testing/debugging
            Console.WriteLine("Dealt 1 card - Size of Deck: " + this.Count);

            return topCard;
        }

        /// <summary>
        /// This method Deal5 is to deal 5 cards as required in lab25
        /// </summary>
        /// <returns></returns>
        public Hand Deal5()
        {
            Console.WriteLine("=====The current size of deck: " + this.Count +"=====");
            Hand topHand = new Hand();

            for (int i = 0; i < 5; i++)
            {                
                Card topCard = this[0];  
                topHand.Add(this[0]);
                this.RemoveAt(0);       //this removes the card indicated by value i from 0 to 5   
                Console.WriteLine("Dealt card {0} = {1} of {2} || Deck size = {3}", i+1, topCard.Face, topCard.Suit, this.Count);             
            }
            return topHand;
        }


    }
}
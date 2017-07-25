using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 25, 2017
* Description: This is a demo for lesson 11
* Version: 0.1 - added card class
*/

namespace COMP123_Lesson11B
{
    public class Card
    {
        //PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERTIES
        public Face Face
        {

            get
            {
                return this._face;
            }

            set
            {
                this._face = value;
            }
        }
        
        public Suit Suit
        {
            get
            {
                return this._suit;
            }

            set
            {
                this._suit = value;
            }
        }

        /// <summary>
        /// This is the main constructor, it takes 2 parameters - face and suit
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        //CONSTRUCTORS
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }


        //PRIVATE METHODS

        //PUBLIC METHODS
    }
}
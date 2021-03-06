﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 25, 2017
* Description: This is a demo for lesson 11
* Version: 0.2 - implemented the ICloneable interface
*/

namespace COMP123_Lesson11B
{
    public class Card : ICloneable
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
        /// <summary>
        /// This method overrides the built-in Clone methods
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        /// <summary>
        /// This method overwrites the first card with the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Overwrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;

        }
    }
}
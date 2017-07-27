using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Name: Wayne Pud
* Date: July 27, 2017
* Description: This is the abstract superclass card list
* Version: 0.1 - Created the CardList abstract class
*/

namespace COMP123_Lesson11B
{
    public abstract class CardList : List<Card>
    {
        //PRIVATE INSTANCE VARIABLES

        //PUBLIC PROPERTIES

        //CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }

        //PRIVATE METHODS
        protected abstract void _initialize();

        //PUBLIC METHODS
    }
}
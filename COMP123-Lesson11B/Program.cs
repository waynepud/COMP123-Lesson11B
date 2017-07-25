﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /* Name: Wayne Pud
 * Date: July 25, 2017
 * Description: This is a demo for lesson 11
 * Version: 0.3 - testing shuffle
 */

namespace COMP123_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Original deck--------------");
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());

            Console.WriteLine("-----------------Shuffled deck ----------------------");
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
        }
    }
}

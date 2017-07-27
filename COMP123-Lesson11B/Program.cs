using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 /* Name: Wayne Pud
 * Date: July 27, 2017
 * Description: This is a demo for lesson 11
 * Version: 0.5 - tested lab25 for dealing 5 cards, sorting and showing highest value cards
 */

namespace COMP123_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine("-----------------Original Deck-----------------");
            Console.WriteLine(deck.ToString());


            Console.WriteLine("-----------------Shuffled deck ----------------------");
            deck.Shuffle();
            Console.WriteLine(deck.ToString());



            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //Console.WriteLine(deck.ToString());

            //hand = deck.Deal5(); //moves the top 5 cards from the deck to the hand object

            hand = deck.Deal5();
            Console.WriteLine("");
            Console.WriteLine(hand.ToString());

            hand.HighestCards(hand);

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_01
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {


        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
        {

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);


        } // end Main

        // PUBLIC STATIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @method CreateDeck
         * @param {List<Card>} deck
         * @returns {void}
         */
        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                switch (suitIndex)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;

                } // end suit switch

                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                } // end for - face

            } // end for - suit

        } // end CreateDeck method
        public static void DisplayDeck(List<Card> deck)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+Current Deck                        +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in deck)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

        } // end Program

    } // end namespace
}
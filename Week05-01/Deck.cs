using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_01
{
    /*
     * <summary>
     * This class extends the List <card> generic type
     * </summary
     * @class deck
     */
    class Deck : List<Card>

    {
        /*
         * <summary>
         * this is the default constructor for the deck class
         * 
         * </summary>
         * @constructor Deck
         */
        public Deck()
        {
            this._createDeck();
        }
        private void _createDeck()
        {
            foreach (Suits suits in Enum.GetValues(typeof(Suits) ))
            {
                foreach (Faces face in Enum.GetValues (typeof(Faces)))
                {
                    this.Add(new Card(face, suits));
                }
            }
            Card myCard =new Card(Faces.Ace, Suits.Hearts);
            // string suit = "";

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                //    switch (suitIndex)
                //    {
                //        case 0:
                //            suit = "hearts";
                //            break;
                //        case 1:
                //            suit = "clubs";
                //            break;
                //        case 2:
                //            suit = "diamonds";
                //            break;
                //        case 3:
                //            suit = "spades";
                //            break;

                //    } // end suit switch

                //    for (int face = 1; face < 14; face++)
                //    {
                //        this.Add(new Card(face, suit));
                //    } // end for - face

                //} // end for - suit

            } // end CreateDeck method
        }
        public void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+Current Deck                        +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
        public void ShuffleDeck()
        { /// creates a pseudo random number sequence and stores it in randim
            Random random = new Random();
            int cardCount = this.Count;

            //iterate throught the index of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; //copy current card to temp location
                int randomCard = random.Next(0, cardCount); //get a random card index
                this[currentCard] = this[randomCard];//copy valiue from random card to current card
                this[randomCard] = tempCard; // copy current curret card to random card
            }
        }
        /**
    * <summary>
    * this method will remove the 0th item from the deck and return it to the caller
    * </summary>
    * @method Deal
    * @returns{card}
    * 
    * 
    */
        public Card Deal()
        {
            Card returnedCard = this[0]; // cop the 0th card in the stack to the returned card
            this.RemoveAt(0); //remove the 0th card
            return returnedCard;
        }

    } // end Program

} // end namespace


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesShuffled;
            deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Deck shuffled {0} times.", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = times; i > 0; i--)
            {
                timesShuffled++;
                List<Card> tempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = times; i > 0; i--)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            List<string> Ranks = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = times; i > 0; i--)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }
    }
}

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
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();

            Player player = new Player() { Name = "Bob" };
            game += player;
            game.ListPlayers();
            game -= player;
            game.ListPlayers();

            //Deck deck = new Deck();
            //deck.Shuffle(3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Rank + " of " + card.Suit);
            //}
            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
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

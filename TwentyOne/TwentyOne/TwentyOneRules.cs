using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Rank, int> _cardValues = new Dictionary<Rank, int>()
        {
            [Rank.Ace] = 1,
            [Rank.Two] = 2,
            [Rank.Three] = 3,
            [Rank.Four] = 4,
            [Rank.Five] = 5,
            [Rank.Six] = 6,
            [Rank.Seven] = 7,
            [Rank.Eight] = 8,
            [Rank.Nine] = 9,
            [Rank.Ten] = 10,
            [Rank.Jack] = 10,
            [Rank.Queen] = 10,
            [Rank.King] = 10
        };
        public static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Rank == Rank.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Rank]);
            result[0] = value;
            if (result.Length == 1) return result;

        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {

        }
    }
}

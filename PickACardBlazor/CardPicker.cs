using System;

namespace PickACardBlazor
{
	class CardPicker
	{
		static Random random = new Random();

		public static string[] PickSomeCards(int numberOfCards)
		{
			string[] pickedCards = new string[numberOfCards];
			for (int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}

			return pickedCards;
		}

		private static string RandomValue()
		{
			int value = random.Next(1, 14);
			if (value == 1) return "Ace";
			if (value == 11) return "Jack";
			if (value == 12) return "Queen";
            if (value == 13) return "King";
			return value.ToString();
        }

		private static string RandomSuit()
		{
			// get random number from 1 to 4
			int value = random.Next(1, 5);

			// return a suit
			if (value == 1) return "Spades";
			if (value == 2) return "Hearts";
			if (value == 3) return "Clubs";
			return "Diamonds";
		}
	}
}


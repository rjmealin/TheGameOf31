using System;
namespace TheGameOf31
{
	public class CardModel
	{
		public SuitTypes Suit { get; set; }
		public int Value { get; set; }

		public CardModel(SuitTypes suit, int val)
		{
			this.Suit = suit;
			this.Value = val;
		}
	}
}


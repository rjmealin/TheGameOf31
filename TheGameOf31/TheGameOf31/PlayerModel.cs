using System;
namespace TheGameOf31
{
	public class PlayerModel
	{
		public List<CardModel> Cards { get; set; } = new List<CardModel>();
		public int PlayerNumber { get; set; }
		public int CardScore { get; set; }
		public int Tokens { get; set; }


		public PlayerModel(int playerNo)
		{
			this.PlayerNumber = playerNo;
			this.Tokens = 4;
		}






		/// <summary>
		///		Calculates the players current score
		/// </summary>
		public void CalculateScore()
		{

		}
	}
}


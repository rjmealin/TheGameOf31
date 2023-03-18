using System;
namespace TheGameOf31
{
	public class GameModel
	{
		public int NumPlayers { get; set; }
		public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();

		public GameModel()
		{
		}

		public void SetNumberOfPlayers(string? noPlayers)
		{
			var res = 0;
			if (!int.TryParse(noPlayers, out res))
			{
               Console.WriteLine("Please enter in a numeric Value!");
				var input = Console.ReadLine();
				this.SetNumberOfPlayers(input);
            }
			else
			{
				Console.WriteLine("thank you");
				this.NumPlayers = res;
			}

		}
	}
}


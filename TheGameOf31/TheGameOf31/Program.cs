// See https://aka.ms/new-console-template for more information
using TheGameOf31;

Console.WriteLine("Hello, Welcome to the game of 31, please select the number of players:");

var noPlayers = Console.ReadLine();

var game = new GameModel();

game.SetNumberOfPlayers(noPlayers);

//create the deck
var deck = new List<CardModel>();
for (var i = 2; i < 12; i++)
{
    if (i == 10)
    {
        //since facecards and 10s have the same value we can just create copies
        var club = new CardModel(SuitTypes.Clubs, i);
        var spade = new CardModel(SuitTypes.Spades, i);
        var heart = new CardModel(SuitTypes.Hearts, i);
        var diamond = new CardModel(SuitTypes.Diamonds, i);
        deck.AddRange(Enumerable.Repeat(club, 4));
        deck.AddRange(Enumerable.Repeat(spade, 4));
        deck.AddRange(Enumerable.Repeat(heart, 4));
        deck.AddRange(Enumerable.Repeat(diamond, 4));
    }
    else
    {
        var club = new CardModel(SuitTypes.Clubs, i);
        var spade = new CardModel(SuitTypes.Spades, i);
        var heart = new CardModel(SuitTypes.Hearts, i);
        var diamond = new CardModel(SuitTypes.Diamonds, i);
        deck.Add(club);
        deck.Add(spade);
        deck.Add(heart);
        deck.Add(diamond);

    }


}

//create players
for (var i = 1; i <= game.NumPlayers; i++)
{
    var player = new PlayerModel(i);
    game.Players.Add(player);

}
//shuffle the deck
deck.Shuffle();

//deal cards out to players
for (var i = 1; i <= 3; i++)
{
    
    for(var j = 0; j < game.Players.Count; j++)
    {
        game.Players[j].Cards.Add(deck[0]);
        deck.RemoveAt(0);
    }
}
Console.WriteLine("game shiuld be set up");


//do a round of the game




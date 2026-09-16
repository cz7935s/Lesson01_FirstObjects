using System.Xml;

namespace Toolkit;

/*
 1. two things about my card that are fixed for good are 1, the card's rank and 2, the card's suit.
 2. one thing that hypothetically could change about the card is whether it's facing up or down.
 3. if the rank and suit of a card were able to change during the game, i imagine that would
 result in some illegal actions. for example, one could just change a disadvantageous card
 into an advantageous one


public record Card
{
    public string Rank { get;  init; } = "";
    public string Suit { get; init; } = "";

    public Card(string rank, string suit)
    {
        string[] validSuits = {"Hearts", "Clubs", "Diamonds", "Spades"};
        string[] validRanks = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        // no jokers?
        
        if (!validSuits.Contains(suit))
        {
            throw new ArgumentException($"Suit {suit} is not valid");
        }

        if (!validRanks.Contains(rank))
        {
            throw new ArgumentException($"Rank {rank} is not valid");
        }
        
        Rank = rank;
        Suit = suit;
    }
}


//--------------------cool thing n1 (Suit object):--------------------

public record Suit(string Name = "", string Color = "Black");

public record Card(int Value, Suit Suit, bool IsFaceUp = true);
 */

//--------------------cool thing n2 ()--------------------
public record Suit(string Name = "", string Color = "Black")
{
    public static Suit Hearts => new Suit("♥","Red");
    public static Suit Diamonds => new Suit("♦","Red");
    public static Suit Clubs => new Suit("♣","Black");
    public static Suit Spades => new Suit("♠","Black");
}

public record Card(int Value, Suit Suit, bool IsFaceUp = true)
{
    
}

namespace _24._3_TheCard;

class Program
{
    static void Main(string[] args)
    {
        List<Card> list = new List<Card>();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                list.Add(new Card((CardColours)i, (CardRanks)j));
            }
        }

        foreach(Card card in list)
        {
            Console.WriteLine(card.ToString());
        }

        Console.ReadLine();
    }
}

public class Card
{
    public CardColours CColour { get; }
    public CardRanks CRank { get; }

    public Card(CardColours cColour, CardRanks cRank)
    {
        CColour = cColour;
        CRank = cRank;
    }

    public bool IsSymbol => CRank == CardRanks.DollarSign || CRank == CardRanks.PercentSign || CRank == CardRanks.HatSign || CRank == CardRanks.Ampersand;
    public bool IsNumber => !IsSymbol;

    public override string ToString()
    {
        string output = IsSymbol ? "Symbol" : "Number";
        return $"The {CColour} {CRank} ---> This is a {output}";
    }
}

public enum CardColours
{
    Red,
    Green,
    Blue,
    Yellow
}

public enum CardRanks
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    DollarSign,
    PercentSign,
    HatSign,
    Ampersand
}
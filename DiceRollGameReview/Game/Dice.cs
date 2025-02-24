namespace DiceRollGameReview.Game
{
    public class Dice
{
    private readonly Random _random;
    private readonly int SidesCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        // 매직 넘버 안티패턴
        return _random.Next(1, SidesCount+1);
    }

    public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");
}}

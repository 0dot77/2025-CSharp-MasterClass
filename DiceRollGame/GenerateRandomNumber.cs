namespace DiceRollGame;

public class GenerateRandomNumber
{
    public int Generate(int min, int max)
    {
        var random = new Random();
        return random.Next(min, max);
    }
}
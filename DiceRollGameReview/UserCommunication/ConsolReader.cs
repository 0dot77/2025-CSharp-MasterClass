namespace DiceRollGameReview.UserCommunication
{
    public static class ConsolReader
{
    public static int ReadInteger(string message)
    {
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
    }
}
}

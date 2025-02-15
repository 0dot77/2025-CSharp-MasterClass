namespace DiceRollGame;

public class HandleUserInputs
{
    public bool CheckUserInput(string userInput)
    {
        try
        {
            int result = int.Parse(userInput);
            Console.WriteLine("int로 변환 성공");
            return true;
        }
        catch (FormatException)
        {
            Console.WriteLine("문자열 형식이 이상함");
            return false;
        }
        catch (OverflowException)
        {
            Console.WriteLine("숫자가 int 범위를 초과함");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}
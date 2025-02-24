using DiceRollGameReview.UserCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGameReview.Game
{
    class GuessingGame
{
    // readonly
    // 생성자 외부에서는 해당 값을 변경할 수 없음
    // 생성자가 호출되는 시점에서만 바꿀 수 있음 -> 다른 Set 메서드를 사용해서 바꿀 수 없음
    // 다른 개발자에게 해당 필드가 변경되지 말아야 함을 전달함
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    // 메서드의 이름을 지을 때 타입도 생각을 해야함
    // 플레이 메서드의 경우에는 플레이 로직을 다룰 것이라고 생각하게 된다.
    // 그런데 bool 값을 반환하게 되면 play로 판단하는 것과 다른 결과값을 (옳더라도) 얻게 된다.
    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

        var triesLeft = InitialTries;

        while (triesLeft > 0)
        {
            var guess = ConsolReader.ReadInteger("Enter your guess: ");
            if(guess == diceRollResult)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong guess. Try again.");
            --triesLeft;
        }
        return GameResult.Loss;
    }

    // 메서드가 클래스의 인스턴스 변수나 속성을 사용하지 않을 때 Static 선언 가능
    // 자주 호출되는 메서드의 경우, static으로 선언하면 인스턴스 생성 비용을 줄일 수 있음
    public static void PrintReseult(GameResult gameResult)
    {
        // Tenary Operator
        string message = gameResult == GameResult.Victory 
            ? "You won!" 
            : "You lost!";
        Console.WriteLine(message);
    }

}
}

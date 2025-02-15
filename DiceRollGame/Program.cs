using System.Diagnostics;
using DiceRollGame;

bool gameComplete = false;
int gamePlayCounter = 0;
var randomNumber = GenerateRandomNumber.Generate(1,6);
var handleUserInputs = new HandleUserInputs();

do
{
    Console.WriteLine("주사위를 굴렸다. 3번의 기회동안 맞춰봐라!");
    
    
    var userInput = Console.ReadLine();

    if (handleUserInputs.CheckUserInput(userInput))
    {
        int parsedUserInput = int.Parse(userInput);
        if (parsedUserInput == randomNumber)
        {
            gameComplete = true;
            Console.WriteLine("맞추다니!");
        }
        else
        {
            gameComplete = false;
            Console.WriteLine("다시 해봐!");
        }

        if (gamePlayCounter == 2)
        {
            Console.WriteLine("이미 다 플레이했다!");
            return;
        }
        else
        {
            gamePlayCounter++;
        }
        
    }
    else
    {
        Console.WriteLine("입력 잘못했다");
    }
} while (!gameComplete);





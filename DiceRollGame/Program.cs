using DiceRollGame;

var randomNumber = new GenerateRandomNumber().Generate(1,6);

Console.WriteLine("Dice rolled. Guess what number is shows in 3 tries.");

var UserInput = Console.ReadLine();

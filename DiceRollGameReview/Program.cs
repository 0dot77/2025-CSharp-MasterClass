// sudo random 코드를 생성한다.
// 동일한 시드 값에 따라서는 항상 같은 순서의 값들을 얻게 된다.
// 가장 좋은 방법은 전체 프로그램에 하나의 랜덤 객체를 사용하는 것이다.
//var random = new Random(12);
//var diceRollResult = random.Next(1, 7);

using DiceRollGameReview.Game;

Season firstSeason = Season.Spring;
Season lastSeason = Season.Winter;

// Casting
// 형 변환을 강제하기
int firstSeasonAsNumber = (int)firstSeason;
int lastSeasonAsNumber = (int)lastSeason;

Console.WriteLine(firstSeason);
Console.WriteLine(firstSeasonAsNumber);

Console.WriteLine(lastSeason);
Console.WriteLine(lastSeasonAsNumber);

Console.ReadKey();

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);
GameResult gameResult = guessingGame.Play();
GuessingGame.PrintReseult(gameResult);

// 열거형의 값은 내부적으로 int로 표현된다.
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


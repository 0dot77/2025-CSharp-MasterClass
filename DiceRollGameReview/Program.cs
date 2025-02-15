// sudo random 코드를 생성한다.
// 동일한 시드 값에 따라서는 항상 같은 순서의 값들을 얻게 된다.
// 가장 좋은 방법은 전체 프로그램에 하나의 랜덤 객체를 사용하는 것이다.
var random = new Random(12);
var diceRollResult = random.Next(1, 7);


Console.ReadKey();

class Dice
{
    private readonly Random _random;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        // 매직 넘버 안티패턴
        return _random.Next(1, 7);
    }
}
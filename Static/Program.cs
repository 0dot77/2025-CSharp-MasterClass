// Static Class

//var calculator = new Calculator();
Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Substract(1, 2)}");

//var anotherCalculator = new Calculator();
Console.WriteLine($"2 - 2 is {Calculator.Multiply(1, 2)}");

Console.WriteLine("Number of Calculator is " + Calculator.NumberOfCalculators);

// Calculator의 경우에는 Stateless - 해당 메서드를 그냥 사용하기만 함
// static _ static 키워드를 메서드에 사용하면 클래스 전체에 속함 -> 따라서 Calculator 자체에서 호출해야 함
// static의 경우에는 모든 것이 동일하게 작동하기를 원함
// 인스턴스를 생성한다는 것 자체가 결국에는 생성자를 사용해서 각기 다른 초기값을 갖고 사용하고자 한다는 의미
static class Calculator
// static 클래스는 static 메서드만 가질 수 있음
// 정적 메서드에서 비정적 메서드를 사용할 수 없음
// 상태를 사용하지 않는 모든 비공개 메서드는 정적으로 만드는 것이 좋음
// 메서드를 정적으로 만들면 약간 더 빠르게 동작함
{
    public static int Add(int a, int b) => a + b;
    public static int Substract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    
    // 모든 const 필드는 암시적으로 정적이다
    public const int NumberOfCalculators = 10;
}

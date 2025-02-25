var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = false;

NumbersSumCalculator calculator =
    shallAddPositiveOnly ? new PositiveNumbersSumCalculator() : new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is " + sum);

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }

        return sum;
    }

    // virtual member 는 상속을 전제하고 있기 때문에 public, protected를 사용해야함
    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    // public int Calculate(List<int> numbers)
    // {
    //     int sum = 0;
    //     foreach (var number in numbers)
    //     {
    //         if (number > 0)
    //         {
    //             sum += number;
    //         }
    //     }
    //
    //     return sum;
    // }
    
    // virtual - override 짝으로 생각하기!
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}

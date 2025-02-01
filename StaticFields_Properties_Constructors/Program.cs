// static properties, properties, constructors

// 정적 클래스와 비정적 클래스 모두 정적 필드와 프로퍼티를 포함할 수 있다.

// 생성자와 정적 메서드를 사용해서 객체가 만들어질 때마다 개수를 측정해줄 수 있음
// 일반적으로 정적 필드와 프로퍼티는 모든 멤버 간에 단일 멤버를 공유해야 함
Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);

class Rectangle
{
    public static int CountOfInstances { get; private set; }
    private static DateTime _firstUsed;
    
    // static constructor를 사용해서 값을 한 번 초기화해줄 수 있음 
    // 정적 필드와 속성을 갖는 것은 위험 -> 진짜 사용할 일이 없음
    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }
    
    public Rectangle(int width, int height)
    {
        ++CountOfInstances;
    }
    
    public int Width { get; }
    private int _height;
    public int GetHeight() => _height;
}
var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new TomatoSauce()
};

foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}


public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    
    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

// 다형성 (Poly - many, morphe - form/shape)
// 추상적인 개념을 사용해서 일반적인 개념이 필요한 곳에서 모두 사용할 수 있도록 만드는 방식
// 목록에 다양한 개체를 저장할 수 있음, 그런데 그 개체를 공통의 인터페이스로 컨트롤 할 수 있음

// Inheritance 상속
// 멤버가 상속되는 클래스르 베이스 클래스, 
// 그 멤버를 상속하는 클래스를 상속 클래스라고 함

// is-a
// interface는 행동과 관계를 정의함

public class Ingredient
{
    // 자체 필드도 가질 수 있음
    // 부모 클래스에서 파생 시킨 이러한 필드 값은 필드 자체는 상속받지만, 부모 클래스의 인스턴스가 생성되고 값이 할당 되었을 때는
    // 독립성을 유지한다.
    public int PublicField;
    public virtual string Name { get; } = "Some Ingredients";

    // 모든 파생 클래스에서 가질 수 있는 공통의 데이터와 메서드를 정의할 수 있음
    public string PublicMethod() => "This method is public";

    // private의 경우에는 파생 클래스에서 사용될 수 없다.
    private string PrivatedMethod() => "This is PRIVATAE";
    
    // protected
    // 보호된 메서드의 경우에는 파생 클래스에서는 사용할 수 있지만, 외부에서 호출은 불가능하다.
    protected string ProtectedMethod() => "This is PROTECTED";
}

// 그럼에도 불구하고 각각의 파생 클래스에서는 각각의 데이터와 메서드를 가질 수 있음
public class Cheddar : Ingredient // is-a class
{
    // override가 사용되지 않았다면, 어떤 클래스를 타입으로 갖느냐에 따라 할당되는 값이 달라진다.
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient // is-a class (is an ingredient)
{
    // virtual 키워드를 부모 클래스에서 사용했다면, 해당 override가 부여된 파생 클래스의 필드의 값을 
    // 적용된 부분을 사용함
    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}
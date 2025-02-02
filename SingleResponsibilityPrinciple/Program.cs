// Single Responsibility Principle

var names = new Names();
var path = new NameFilePathBuilder().BuildFilePath();
var nameFormattor = new NamesFormatter();
var stringsTextualRepository = new StringTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    
    // 클래스의 이름으로 기능을 설명하고, 메서드는 앞에서 읽은 클래스의 이름(기능)을 활용해
    // 쉽게 유추할 수 있도록 한다.
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exists.");
    
    // 읽기용으로만 필드를 공개하면 위험하다.
    stringsTextualRepository.Write(path, names.All);
}

// 단일 책임 원칙
// SOLID 원칙 중 하나
// 클래스는 한 가지의 일만 담당해야한다.

// Refactoring - 1 
// 하나의 책임만 가질 수 있도록 클래스를 구성하기
class NamesValidator
{
    // 메서드의 이름을 지을 때도 클래스의 이름을 시작으로 고려를 해보는 것이 좋다.
    // 어쨌든 NameValidator. 으로 시작하기 때문에, . 이후에 오는 것에 names가 붙어야 할 이유는 없다.
    public bool IsValid(string name)
    {
        return name.Length >= 2 &&
               name.Length < 25 &&
               char.IsUpper(name[0]) &&
               name.All(char.IsLetter);
    }
}

// 데이터를 읽고 쓰거나, 저장하거나 할 때는 Repository 이름을 사용하는 것이 좋음
class StringTextualRepository
{
    // Unix system : \n
    // Non Unix System : \r\n
    private static readonly string Separator = Environment.NewLine;
    
    // ReadFromTextFile 이라는 이름은 텍스트 파일에서 텍스트를 읽는 기능까지만 진행한다
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        
        // Environment를 사용해서 어떤 운영체제에서든지 동작할 수 있도록 함
        return fileContents.Split(Environment.NewLine).ToList();
    }
    
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Environment.NewLine, strings));
    }
}

class NameFilePathBuilder
{
    public string BuildFilePath()
    {
        return "names.txt";
    }
}

class NamesFormatter
{
    public string Format(List<string> names)
    {
        // 기능이 어떤 상황에서 쓰는지에 대해서도 한 번쯤 고민을 해야한다.
        // Format의 경우에는 상황에 따라서 다른 형식을 요구받을 수 있다.
        // 같은 기능으로 묶을 수 있다고 판단되는 파일 이름의 경우에는 거의 모든 경우에 같은 형식을 사용
        // 따라서 반복을 묶지 못한 느낌보다는, 필요한 반복일 때도 있다는 사실을 주지해야 함
        return string.Join(Environment.NewLine, names);
    }
}
class Names
{
    public List<string> All { get; } = new List<string>();
    
    // 어차피 AddName 메서드에서 사용해야하기 때문에 매번 객체를 만들어서 사용하는 것이 아닌
    // 한 번 만들어졌을 때 사용할 수 있도록 변수화한다.
    private readonly NamesValidator _namesValidator = new NamesValidator();
    
    public void AddNames(List<string> stringsFromFile)
    {
        foreach (var name in stringsFromFile)
        {
            AddName(name);
        }
    }

    private void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }


}
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
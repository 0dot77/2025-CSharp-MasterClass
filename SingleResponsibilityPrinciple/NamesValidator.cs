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
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
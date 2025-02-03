namespace SingleResponsibilityPrinciple.DataAccess;
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
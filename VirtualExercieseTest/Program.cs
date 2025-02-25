var ex = new Exercise();
Console.WriteLine(ex.ProcessAll(["Goeee", "dkjqk"]));
public class Exercise
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
        {
            new StringsTrimmingProcessor(),
            new StringsUppercaseProcessor()
        };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }

        return result;
    }
}

public class StringsProcessor
{
    public virtual List<string> Process(List<string> words)
    {
        return words;
    }
}
public class StringsUppercaseProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        List<string> trimmedStrings = new List<string>(words.Count);
        foreach (var word in words)
        {
            int halfOfCharacters = (int)word.Length / 2;
            string trimmedWords = word.Substring(halfOfCharacters);
        }

        return words;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    public override List<string> Process(List<string> word)
    {
        return word;
    }
}
using api.Domain.Interface;

public class TextService : ITextService
{
    public string ConcatText(string t1, string t2)
    {
        return $"{t1}{t2}";
    }
}
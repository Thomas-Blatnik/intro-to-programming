namespace CSharpSyntax;

public delegate bool IsMatch(int x);
public class NumberFilter
{
    public List<int> Filter(List<int> numbers,IsMatch isMatch)
    {
        var results = new List<int>();
        foreach (var number in numbers) 
        {
        
                if (isMatch.Invoke(number))
                {
                    results.Add(number);
                }
         }

        return results;
    }

    private bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}
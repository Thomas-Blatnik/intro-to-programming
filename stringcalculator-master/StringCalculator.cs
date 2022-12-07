
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        char customDelimiter = ',';

        if (numbers.StartsWith("//"))
        {
            customDelimiter = numbers.ToCharArray()[2];
            numbers = numbers.Substring(4);
        }

        if (numbers == "")
        {
            return 0;
        }

        string[] numbersArray = numbers.Split(new char[] {',','\n',customDelimiter});
        int sum = 0;

        foreach(string number in numbersArray)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}

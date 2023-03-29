
Console.WriteLine("Insert a roman number:");

string romanNumber = Console.ReadLine().ToUpper();

Solution solution = new Solution();

Console.WriteLine(solution.RomanToInt(romanNumber));

public class Solution
{
    
    private Dictionary<char, int> romanNumberValues = new Dictionary<char, int>() { { 'I', 1 },
                                                                                    { 'V', 5 },
                                                                                    { 'X', 10 },
                                                                                    { 'L', 50 },
                                                                                    { 'C', 100 },
                                                                                    { 'D', 500 },
                                                                                    { 'M', 1000 }};

    public int RomanToInt(string s)
    {
        int value = 0;
        int previousValue = 0;
        int actualValue = 0;

        for (int i = 0; i < s.Length; i++)
        {
            actualValue = romanNumberValues[s[i]];

            if (previousValue < actualValue)
            {
                value += (actualValue - 2*previousValue);
            } else
            {
                value += actualValue;
            }

            previousValue = actualValue;

        }

        return value;
    }
}
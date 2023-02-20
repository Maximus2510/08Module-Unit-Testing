public class OddEvenKata

{
    public static string PrintNumbers(int number)
    {
        if (IsEven(number))
        {
            return "Even";
        }
        else if (IsOdd(number))
        {
            return "Odd";
        }
        else
        {
            return number.ToString();
        }
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        if(number % 2 == 0)
        {
            return false;
        }
        for (int i = 3; i < Math.Sqrt(number); i += 2)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static List<string> PrintNumbersInRange(int start, int end)
    {
        List<string> results = new List<string>();

        for(int i = start; i <= end; i++)
        {
            results.Add(PrintNumbers(i));
        }
        return results;
    }
}
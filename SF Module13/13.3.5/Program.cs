using System.Collections;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May" };

        var missing = new ArrayList() { 1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        GetMissing(months, missing);
    }


    public static void GetMissing(List<string> monthsIn, ArrayList missing)
    {
        int startIndex = 4;
        var missedStrings = missing.GetRange(startIndex, missing.Count - startIndex);

        string[] strings=new string[missing.Count - startIndex];

        missedStrings.CopyTo(strings);

        foreach (string missedString in missedStrings)
            monthsIn.Add(missedString);

        foreach (var month in monthsIn) { Console.WriteLine(month); }
    }
}
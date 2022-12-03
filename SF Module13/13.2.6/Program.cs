using System.Collections;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public ArrayList ArrListCovert(ArrayList input)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int resultCount = 0;

        foreach (var item in input)
        {
            if (item is string)
            {
                stringBuilder.Append(item);
            }
            else if (item is int)
            {
                resultCount += (int)item;
            }

        }

        var str = stringBuilder.ToString();
        ArrayList result = new ArrayList() { resultCount, str };


        return result;

    }

}
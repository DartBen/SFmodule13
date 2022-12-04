internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Введите строку");
            var str =Console.ReadLine();
            Method(str);
        }
    }


    public static void Method(string str)
    {
        var strIn = str;

        var hSet = new HashSet<char>();
        var hSet2 = new HashSet<char>();

        string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        foreach (string number in numbers)
        {
            hSet2.Add(number[0]);
        }

        foreach (char ch in strIn)
        {
            hSet.Add(ch);
        }
        if (hSet.Overlaps(hSet2))
            Console.WriteLine("Есть числа");

        Console.WriteLine(hSet.Count);
    }
}
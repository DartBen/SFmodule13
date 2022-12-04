internal class Program
{
    private static void Main(string[] args)
    {
        var strIn = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.1 2";

        var hSet = new HashSet<char>();
        var hSet2 = new HashSet<char>();

        string[] numbers = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        foreach(string number in numbers)
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
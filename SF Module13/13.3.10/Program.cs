internal class Program
{
    private static void Main(string[] args)
    {
        var strIn = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

        var hSet = new HashSet<char>();
        foreach (char ch in strIn)
        {
            hSet.Add(ch);
        }

        Console.WriteLine(hSet.Count);

    }
}
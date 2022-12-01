internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool IsSorted(int[] ints)
    {
        for (int a = 0; a < ints.Length - 1; a++)
        {
            if (ints[a] > ints[a + 1])
            {
                return false;
            }
        }
        return true;
    }
}
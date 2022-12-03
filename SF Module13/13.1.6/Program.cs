using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)

    {
        string path = "C:\\Users\\Dima\\Google Диск\\Repos\\SF Module 13\\cdev_Text.txt";
        string[] spliters = { " ", "\r", "\n" };

        try
        {
            //using (FileStream fsSource = new FileStream(path, FileMode.Open, FileAccess.Read))
            //{
            //    string[] readText = File.ReadAllLines(path);
            //    StringBuilder strBuilder= new StringBuilder();

            //    foreach (string str in readText)
            //    {
            //        strBuilder.Append(str);
            //    }

            //    string text = strBuilder.ToString();
            //    string[] Test = text.Split(spliters, StringSplitOptions.RemoveEmptyEntries);

            //    WriteLine ($"Длина массива: {Test.Length}"); 
            //    ReadKey();
            //}



            string text = File.ReadAllText(path);
            var Test = text.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            WriteLine($"Длина массива: {Test.Length}");

        }
        catch (Exception exception)
        {
            WriteLine(exception.Message);
        }




    }
}
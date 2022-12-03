using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        var months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        var numbers = new[] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 };


        //var arrList = new ArrayList();

        //Console.WriteLine(months.Length);
        //Console.WriteLine(numbers.Length);

        //if (months.Length == numbers.Length)
        //{
        //    for (int i = 0; i < months.Length; i++)
        //    {
        //        arrList.Add(months[i]);
        //        arrList.Add(numbers[i]);
        //    }
        //}

        //foreach(var a in arrList)
        //{
        //    Console.WriteLine(a);
        //}


        /* Не согласен с заданием- если нужно чтобы за каждым месяцем шло его числовое значение то апрель нельзя пропускать*/
        var combinedList = new ArrayList();

        //  пробегаемся по массиву чисел
        foreach (var number in numbers)
        {
            // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
            combinedList.Add(months[number - 1]);

            // добавляем его порядковый номер
            combinedList.Add(number);
        }

        foreach (var value in combinedList)
            Console.WriteLine(value);
    }
}
using System;
using System.Collections.Generic;

namespace ExceptWithTest
{
    class Program
    {
        static void Main()
        {
            // Создадим два множества
            SortedSet<char> lettersOne = new SortedSet<char>();
            SortedSet<char> lettersTwo = new SortedSet<char>();

            //  Добавим элементы в первую
            lettersOne.Add('A');
            lettersOne.Add('B');
            lettersOne.Add('C');
            lettersOne.Add('Z');

            // выведем
            PrintCollection(lettersOne, "Первая коллекция: ");

            // Добавим элементы во вторую
            lettersTwo.Add('X');
            lettersTwo.Add('Y');
            lettersTwo.Add('Z');

            // выведем
            PrintCollection(lettersTwo, "Вторая коллекция");

            //  Выполним вычитание множеств
            lettersOne.ExceptWith(lettersTwo);

            // Выведем результат
            PrintCollection(lettersOne, "Результат вычитания");
        }

        static void PrintCollection(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
    }
}
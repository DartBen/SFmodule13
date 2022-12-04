internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Contact // модель класса
{
    public Contact(string name, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public long PhoneNumber { get; }
    public String Email { get; }


    //public static void AddUnique(Contact contact, List<Contact> phoneBook)
    //{
    //    if (!phoneBook.Contains(contact))
    //    {
    //        phoneBook.Add(contact);
    //        phoneBook.Sort();
    //    }
    //}

    public static void AddUnique(Contact contact, List<Contact> phoneBook)
    {
        bool exist = false;

        foreach (Contact cont in phoneBook)
        {
            if (cont.Name==contact.Name)
            {
                exist= true;
                break;
            }

        }

        if (!exist)
        {
            phoneBook.Add(contact);
        }

        //  сортируем список по имени
        phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

        foreach (Contact cont in phoneBook)
        {
            Console.WriteLine(cont.Name+": "+cont.PhoneNumber);
        }

    }
}
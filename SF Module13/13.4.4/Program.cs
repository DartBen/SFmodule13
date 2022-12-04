internal class Program
{
    private static void Main(string[] args)
    {
        //    Console.WriteLine("Hello, World!");

        Dictionary<string, Contact> contacts = InitDictionary();
        Console.WriteLine("Init");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact.Key+ ": " + contact.Value.PhoneNumber);
        }

        contacts.TryAdd("Name3", new Contact(85157195701, "xxxx@gmail.com"));

        Console.WriteLine("ADD");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        }

        if (contacts.ContainsKey("Name3"))
        {
            contacts["Name3"].PhoneNumber = 1313;
        }
        Console.WriteLine("After change");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        }
    }

    public static Dictionary<string, Contact> InitDictionary()
    {
        var contacts = new Dictionary<string, Contact>();
        contacts.TryAdd("Name1", new Contact(111, "ggg@gmail.com"));
        contacts.TryAdd("Name2", new Contact(222, "UUU@gmail.com"));
        return contacts;
    }
}

public class Contact // модель класса
{
    public Contact(/*string name,*/ long phoneNumber, String email) // метод-конструктор
    {
        //Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    //public String Name { get; }
    public long PhoneNumber { get; set; }
    public String Email { get; set; }
}
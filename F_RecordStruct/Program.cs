
// Example 1: Defination of record is working normally as a class in C# 10
internal record Person(string FirstName, string LastName, string Address);

// Example 2: Defination of record is working normally as a struct in C# 10
internal record struct Person1(string FirstName, string LastName, string Address);
internal class PersonInfo
{
    internal static void Main()
    {
        var persion=new Person("Abc", "Jha", "New Delhi");

        var persion1 = new Person1("Xyz", "Jha", "Mumbai");

        Console.WriteLine($"Welcome to {persion.FirstName} {persion.LastName} !!");

        Console.WriteLine($"Welcome to {persion1.FirstName} {persion1.LastName} !!");
    }
}

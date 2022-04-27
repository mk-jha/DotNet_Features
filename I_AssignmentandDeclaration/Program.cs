public class Student
{
    public string Name;
    public string Email;
    public Student(string name, string email)
    {
        this.Name = name;
        this.Email = email;
    }
    // creating deconstruct  
    public void Deconstruct(out string name, out string email)
    {
        name = this.Name;
        email = this.Email;
    }
}

class Program
{
    static void Main(string[] args)
    {

        var student = new Student("Abc Jha", "murari@abc.com");

        //Example 1: Declared veriable first then deconstruct the object to an individual veriable in C# 10

        string name, email;
        (name, email) = student;
        Console.WriteLine(name + " " + email);


        var student1 = new Student("Xyz Jha", "murari@abc.com");

        //Example 2: Mixed declaration in deconstruction is allowed in C# 10

        string nameA;
        (nameA, string emailA) = student1;

        Console.WriteLine(nameA + " " + emailA);
    }
}
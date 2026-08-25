public class Program
{
    /* 
        Access Modifiers
        https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers 

        Properties
        https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties 

        When should you use properties vs fields?
        - DO NOT provide instance fields that are public or protected.
        - You should provide properties for accessing fields instead of making 
        them public or protected.
        Source: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/field
    */

    static void Main()
    {
        Person p1 = new Person("123456", "Mike Harris", 151);
        // Console.WriteLine(p1.BSN); //Error
        // p1.BSN = "error"; // Error

        Console.WriteLine(p1.Name);
        // p1.Name = "Michael Harris"; // Error

        // Console.WriteLine(p1.Age); //Error
        // p1.Age = -1; //Error

        // Console.WriteLine(p1.ID);

        Person p2 = new Person("123456");

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Employee e1 = new Employee("83838383", "Sarah Smith", -32, "232323");
        Console.WriteLine(e1);

        // Console.WriteLine(e1.ID);
    }
}
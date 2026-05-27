public class Person
{
    public string Name { get; set; }
    public Person Child { get; set; }
    
    public Person(string name, Person child)
    {
        Name = name;
        Child = child;
    }
}
public class Person
{
    public string Name { get; set; }
    public bool HasDriverLicense { get; set; }

    public Person(string name, bool hasDriverLicense)
    {
        Name = name;
        HasDriverLicense = hasDriverLicense;
    }
}
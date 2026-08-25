public class Person
{
    public string BSN;
    public string Name;

    // Notice that by convention private variables begin with an underscore (_); 
    // public members begin with an uppercase letter
    private int _age;

    // Default for class members is private so no need to write private
    // int _age;

    public Person(string bsn, string name, int age)
    {
        BSN = bsn;
        Name = name;
        SetValidAge(age);
    }

    public Person(string bsn, string name)
        : this(bsn, name, 0)
    {
    }

    public Person(int bsn, string name)
        : this(Convert.ToString(bsn), name)
    {
    }

    public Person(Person other)
        : this(other.BSN, other.Name, other._age)
    {
    }

    public void IncreaseAge()
    {
        SetValidAge(_age + 1);
    }

    // I would like to be able to implement 
    // this method differently in derived classes
    // A virtual method can be overridden 
    public virtual string GetID()
    {
        return $"BSN: {BSN}";
    }

    // Overriding ToString from the Object class
    public override string ToString()
    {
        return $"BSN: {BSN}, Name: {Name}, Age: {_age}";

    }
    // I would like to ensure that _age is always set to a valid age
    // I do not want to allow this to be used outside the class
    // Since they can use IncreaseAge
    private void SetValidAge(int age)
    {
        // _age = Math.Clamp(age, 0, 150);
        if (age < 0)
        {
            _age = 0;
        }
        else if (age > 150)
        {
            _age = 150;
        }
        else
        {
            _age = age;
        }
    }
}

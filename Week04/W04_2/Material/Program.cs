public class Program
{
    /*
                            Object
                              |
                        +-----+-----+
                        |           |
                     Person        Car
                        |
                +-------+-------+
                |               |
           Student          Employee
                                |
                                |
                             Manager
    */

    static void Main2()
    {
        Casting();
        OverrideToString();
        OverrideAndVirtual();
        InheritanceHierarchy();
    }

    public static void Casting()
    {
        // Student IS a Person
        Person student = new Student("123456", "Sarah Smith", 27, "525252", 2022);

        // Cannot access student members, only Person members
        // Console.WriteLine(student.StudentID); //Error

        // Cast using ()
        double PI = 3.14;
        int PI_int = (int)PI;

        string ID = ((Student)student).StudentID;

        // Cast using as
        ID = (student as Student).StudentID;

        // What if it is not possible to cast it? 
        Person person = new Person("654321", "John Doe");

        // Invalid Cast using () InvalidCastException
        // Still have autocomplete suggestion!
        // string noNumber = ((Student) person).StudentID; //InvalidCastException

        // Invalid Cast using as NullReferenceException
        // string noEmail = (person as Student).StudentID; //NullReferenceException 

        // Cast using as, store result, check for null
        Student test = student as Student;
        if (test != null)
        {
            Console.WriteLine(test.StudentID);
        }
        // Null-conditional operator ?. (Same as above code)
        Console.WriteLine(test?.StudentID);

        // The is operator
        bool testIfStudent = student is Student;

        // is and as in if
        if (student is Student)
        {
            Student st = student as Student;
            Console.WriteLine(st.StudentID);
        }

        // pattern matching and is operator
        if (student is Student asStudent)
        {
            Console.WriteLine(asStudent.StudentID);
        }
    }

    public static void OverrideToString()
    {
        // Student IS A Person
        Person studentIsPerson = new Student("7473729", "Bill Briggs", 22, "0398176", 2024);

        Person person = new Person("654321", "John Doe");

        // person. Look at what is available
        // All classes inherit from the Object class

        // A Person is an Object 
        Object o = new Person("8726353", "Lisa Murphy");
        // o. (look at what is available)

        // ToString() -> Print name of class
        // https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-8.0
        // Note the word *virtual* in the method signature
        Console.WriteLine(person.ToString());

        // ToString() called if you print the object
        Console.WriteLine(person);

        // Let's make a better ToString in Person
        Console.WriteLine(person);

        // Let's make a better ToString in Student
        Student student = new Student("3626181", "Sam Harris", 22, "1234321", 2024);
        Console.WriteLine(student);

        // Notice that an override really replaces the method, 
        // even if we store the object in a base container
        Console.WriteLine(studentIsPerson);

        // Let's look at Car and override ToString there too
        Car myCar = new Car("Toyota");
        Console.WriteLine(myCar);
    }

    public static void OverrideAndVirtual()
    {
        Person person = new Person("654321", "John Doe");

        // Let's make ShareID virtual as it may work differently in derived classes
        Console.WriteLine(person.GetID());

        Student student = new Student("3626181", "Sam Harris", 22, "1234321", 2023);

        // Let's override ShareID in Student
        Console.WriteLine(student.GetID());
    }

    public static void InheritanceHierarchy()
    {
        /*
            Let's look at Employee and Manager and add ToString() methods.
            Then let's create a List of Persons.
        */
        List<Person> people = new List<Person>() {
            new Person("654321", "John Doe", 33),
            new Student("3626181", "Sam Harris", 22, "1234321", 2022),
            new Person("873562", "Lisa Murphy", 27),
            new Employee("987645", "Jane Doe", 22, "121212"),
            new Manager("121232", "Max Power", 44, "122312", "IT")
        };
        foreach (var person in people)
        {
            person.IncreaseAge();
            if (person is Student asStudent)
            {
                Console.WriteLine($"Hi, I am a student with ID {asStudent.StudentID}");
            }
            else if (person is Employee asEmployee)
            {
                Console.Write("Employee");
                if (asEmployee is Manager asManager)
                {
                    Console.Write($" Manager of {asManager.Department}");
                }
                Console.WriteLine();
            }
            // Why does this not run? Think of the hierarchy
            // else if (person is Manager asManager)
            // {
            //     Console.Write($" Manager of {asManager.Department}");
            // }
            else
            {
                Console.WriteLine("Person");
            }
            
            Console.WriteLine(person);
            Console.WriteLine(person.GetID());
        }
    }

    public static void PublicPrivate()
    {
        // Let's make Age, SetValidAge() private -> why?
        Person person = new Person("654321", "John Doe");
        // person._age = -1; //Error when private
        // Console.WriteLine(person._age); //Error when private
        // person.SetValidAge(); // Error
    }
}
public class PersonUtils
{
    public static void PersonTester()
    {
        /*
            Pair exercise 1: 
            Given the Person class, 
            create the following scenario:
                Lisa has a child Bob
                Bob has a child Tim
                Tim has a child Jane
                Jane has no child
        */
        Person tree = Create();

        /*
            Pair exercise 2: 
            Can you print out all the people in the family line?
            For example:
            Lisa
            Bob
            Tim
            Jane

            Can you add formatting?
            Lisa
            -Bob
            --Tim
            ---Jane
        */
        Print(tree);
        PrintFormatted(tree);

        Person tree2 = Create2();
        Print(tree2);
        PrintFormatted(tree2);


        /*
            Pair exercise 3: 
            Write a method to Find a name in the family line.
            `public static bool Find(Person p, string name)`
            return `true` if you find the name and `false` otherwise.
        */
        bool find1 = Find(tree, "Lisa");
        bool find2 = Find(tree, "Bob");
        bool find3 = Find(tree, "Tim");
        bool find4 = Find(tree, "Jane");
        bool find5 = Find(tree, "Jan");
        bool find6 = Find(tree, "Liam");
    }

    /*
        Lisa has a child Bob
        Bob has a child Tim
        Tim has a child Jane
        Jane has no child
    */
    public static Person Create()
    {
        Person tree =
            new Person("Lisa",
                new Person("Bob",
                    new Person("Tim",
                        new Person("Jane", null))));

        // or
        Person p1 = new Person("Jane", null);
        Person p2 = new Person("Tim", p1);
        Person p3 = new("Bob", p2);
        Person p4 = new("Lisa", p3);

        return p4;
    }

    public static Person Create2()
    {
        Person generation5 = new Person("Emma", null);
        Person generation4 = new Person("David", generation5);
        Person generation3 = new Person("Sophia", generation4);
        Person generation2 = new Person("Michael", generation3);
        Person generation1 = new Person("Elizabeth", generation2);
        return new Person("William", generation1);
    }

    // Print out all the people in the family line
    public static void Print(Person p)
    {
        if (p == null)
        {
            return;
        }
        Console.WriteLine(p.Name);
        Print(p.Child);

         /*
            Non recursive solution
            while(p != null)
            {
                Console.WriteLine(p.Name);
                p = p.Child;
            }
        */
    }



    /*
        Print out all the people in the family with formatting
        Lisa
        -Bob
        --Tim
        ---Jane
    */
    public static void PrintFormatted(Person p, string indent = "")
    {
        if (p == null)
        {
            return;
        }
        Console.WriteLine($"{indent}{p.Name}");
        PrintFormatted(p.Child, indent + "-");
    }

    // Find a name in the family line
    public static bool Find(Person p, string name)
    {
        if (p == null)
        {
            return false;
        }
        if (p.Name == name)
        {
            return true;
        }
        return Find(p.Child, name);
    }
}



static class Program
{
    static void Main()
    {
        string klas = "BC11G";
        int year = 1;
        int semester = 2;

        float minimumGrade = 5.5f;
        double onTime = 0.99;

        long longNumber = 238L;
        bool passedBaseCamp = true;
        char Initial = 'B';


        klas = "INF1E";


        // For now not advised. 
        // learn how to work with data types yourself
        var number = 2;
        //number = "hoi";

        Comments(param1: "hoi");

        Operators();

        ConsoleInOutput();
    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        static void Comments(string param1)
    {
        // line comments. same as '#' in python

        /*
        block comments
        */
    }

    static void Operators()
    {
        double f = 2.2;
        int a = 5;
        int b = (int)f;

        // addition
        int c = a + b;
        // subtraction
        c = a - b;

        float aa = a;
        // Be aware of integer division
        float d = aa / b; // this will give 2, not 2.5. 
        // In python it is the // operator

        // Shortcuts ++ -- (post/pre) += -= *= /= 
        int num = 1;
        int num2 = num++; // post
        int num3 = ++num; // pre
        num += 10;
    }

    static void ConsoleInOutput()
    {
        Console.Write("Hello ");
        Console.WriteLine("World");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        // string concatenation
        Console.WriteLine("Hello " + name);
        // string interpolation
        Console.WriteLine($"Hello {name}");
        string gradeString = $"Your grade is {6.5:f2}";// f2 means 2 decimal places
    }

    static void typeConversions()
    {
        int a = 5;
        double b = a; // implicit conversion

        double c = 5.5;
        int d = (int)c; // explicit conversion, will truncate the decimal part


        // Converting from string
        int number1 = int.Parse("123");
        double number2 = Convert.ToDouble("123.45");

        if (int.TryParse("2", out int n))
        {
            
        }

        long longNumber = 1234567890123456789L;
        int shortNumber = (int)longNumber; // This will cause data loss, be careful!
    }

    static void ErrorsAndWarnings()
    {
        // warning for example unused variables
        int unusedVariable = 0; 

        // runtime errors:
        // int divisionByZero = 5 / 0; // This will throw a DivideByZeroException

        // compile time errors:
        // int invalidSyntax = 5 / ; // This will cause a compile-time error
        // int typeMismatch = "hello"; // This will cause a compile-time error

        // logical errors
        int average = (1 + 2) * 2;
    }

    // Class Exercises: W01.1.T01 - W01.1.T03


    // Part 2
    static void part2()
    {
        StringMethods();
    }

    static void StringMethods()
    {
        string text = "Hello World";

        // Length
        int length = text.Length;

        // ToUpper and ToLower
        string upper = text.ToUpper();
        string lower = text.ToLower();

        // Substring
        string sub = text.Substring(0, 5); // "Hello"

        // Contains
        bool containsWorld = text.Contains("World");

        // Replace
        string replaced = text.Replace("World", "C#");

        // Trim
        string padded = "   Hello World   ";
        string trimmed = padded.Trim(); // "Hello World"

        // string comparison
        bool isEqual = text == "Hello World"; // true
        bool isEqualIgnoreCase = text.Equals("hello world", StringComparison.OrdinalIgnoreCase);
    }

    static void comparisonOperators()
    {
        bool b1 = 5 <= 2;
        bool b2 = 5 < 2;

        bool b3 = "a" != "b";
    }

    static void logicalOperators()
    {
        bool b = !true; // not
        b = true && true; // and
        b = false || true; // or
    }

    static void ifElse()
    {
        int age = 17;
        if (age >= 18)
        {
            Console.WriteLine("You can vote!");
            string scopedResult = "My own scope";
        }
        else
        {
            Console.WriteLine($"You have to wait {18-age} years!");
            age++;
        }

        //Console.WriteLine(scopedResult);

        string canVote = age >= 18 ? "yes" : "no";

        if (canVote == "yes")
        {
            Console.WriteLine("Welcome 18 March");
        }
        else if (canVote == "no")
        {
            Console.WriteLine("Probably soon :)");
        }
        else
        {
            Console.WriteLine("Sorry don't understand your answer");
        }


    }

    // Class Exercises: W01.1.T04 - W01.1.T07
    public static void SwitchStatementAndExpressions()
    {
        // What does the following code do?
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a symbol");
        string symbol = Console.ReadLine();

        string result = $"{num1} {symbol} {num2} = ";


        if (symbol == "+")
        {
            result += (num1 + num2);
        }
        else if (symbol == "-")
        {
            result += (num1 - num2);
        }
        else if (symbol == "*")
        {
            result += (num1 * num2);
        }
        else if (symbol == "/")
        {
            result += (num1 / num2);
        }
        else
        {
            result += "Operation not supported";
        }
        Console.WriteLine(result);

        string result2 = $"{num1} {symbol} {num2} = ";
        switch (symbol)
        {
            case "+":
                result2 += (num1 + num2);
                break;
            case "-":
                result2 += (num1 - num2);
                break;
            case "*":
                result2 += (num1 * num2);
                break;
            case "/":
                result2 += (num1 / num2);
                break;
            default:
                result += "Operation not supported";
                break;
        }

        string result3 = $"{num1} {symbol} {num2} = ";
        result3 += symbol switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2,
            _ => "Operation not supported"
        };

        int number = 42;
        string description = number switch
        {
            <10 => "Lower than 10",
            >= 10 and <= 15 => "between 10 and 15",
            > 20 when number % 2 == 0 => "even above 20",
            _ => "the rest"
        };
    }

    // Class Exercises: W01.1.T08 - W.01.1.T09
}
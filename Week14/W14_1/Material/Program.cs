public class Program
{
    static void Main(string[] args)
    {
        // Search Google for recursion

        MethodsRevision();

        PositionProblem();

        FactorialExplanation();
        int result = Factorial(5);
        int result2 = FactorialNonRecursive(5);
        // Which implementation do you prefer and why?
        RecursionVsIterativeSolution();

        PersonUtils.PersonTester();
    }

    public static void MethodsRevision()
    {
        // Revision: methods calling other methods
        // Introduction to calling stack
        int calc = MethodA(2);

        // Show stack overflow exception
        // HelloWorld();
    }

    private static int MethodA(int a)
    {
        Console.WriteLine("In method A");
        int aCalc = a * 2;
        int bCalc = MethodB(aCalc);
        return bCalc;
    }

    private static int MethodB(int b)
    {
        Console.WriteLine("In method B");
        int aCalc = b + 1;
        int cCalc = MethodC(aCalc);
        return cCalc;
    }

    private static int MethodC(int c)
    {
        Console.WriteLine("In method C");
        int cCalc = c + 2;
        return cCalc;
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, world!");
        HelloWorld();
    }

    public static void PositionProblem()
    {
        /* 
            Team exercise (non coding):
            You are standing in a queue. 
            You would like to know what your place is in the queue,
            however, you cannot exit the queue to find out as
            you will lose your place in the queue.
            Come up with a strategy to figure out your place in the 
            queue.
        */
        PositionSolution();
    }

    public static void FactorialExplanation()
    {
        /*
            What is factorial?
            Can you immediately tell me what 5! is?
            5 x 4 x 3 x 2 x 1
            Just like you a computer needs to figure it out, step by step.

            Could we use a smaller version of the problem, to solve the problem?
            5 x (4 x 3 x 2 x 1)
            (4 x 3 x 2 x 1) = 4!
            Factorial(5) = 5 * Factorial(4)
            
            What is the smallest version of the problem that we can think about?
            Factorial(1) = 1 (the person at the top of the queue)
            
            Factorial(5) = 5 * Factorial(4)
            Factorial(4) = 4 * Factorial(3)
            Factorial(3) = 3 * Factorial(2)
            Factorial(2) = 2 * Factorial(1)
            Factorial(1) = 1

            Filling in these values....
            Factorial(2) = 2 * 1 = 2
            Factorial(3) = 3 * 2 = 6
            Factorial(4) = 4 * 6 = 24
            factorial(5) = 5 * 24 = 120
        */
    }

    public static int Factorial(int n)
    {
        // Base case
        if (n == 1)
        {
            return 1;
        }
        // Recursive case and recursive call
        return n * Factorial(n - 1);
    }

    
    public static int FactorialNonRecursive(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void RecursionVsIterativeSolution()
    {
        /*
            All recursive programs can be rewritten iteratively 
            and all iterative programs can be written recursively, 
            however, it may not always be practical to do so.
            - The iterative version might be more complex and less intuitive 
            than the recursive one.
            - Recursive solutions can sometimes lead to excessive memory usage 
            and stack overflow errors if the recursion depth is too high.
        */
    }

    private static void PositionSolution()
    {
        /*
            To find your position without leaving the line, 
            use a recursive "ask-and-pass" strategy: 
            tap the person in front and ask for their position. 
            They repeat this recursively until it reaches 
            the front (person 1). As the answer passes back, 
            each person adds 1 to determine their exact place 
            in the queue.
        */
    }
}
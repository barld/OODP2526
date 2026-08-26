public static class ListExtensions
{
    private static readonly Random _rng = new();

    /*
        Consider the PickRandom method below. 
        What would I change if I wanted it to work with ints?
    */
    public static string PickRandom(List<string> list)
    {
        if (list == null || list.Count == 0)
            return null!;

        return list[_rng.Next(list.Count)];
    }
            
    /*    
        public static int PickRandom(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return 0;
            }
            return list[_rng.Next(list.Count)];
        }
    
        What about Weapon objects, bools, etc.?

        We could consider overloading it, but
        what if I wanted it to work for any type?

        Generics can help us.  

        Use generics when the same code should work 
        with different data types while still 
        maintaining type safety.      
    */

    public static T? PickRandom<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
            return default!;

        return list[_rng.Next(list.Count)];
    }

    /* 
        Try this one yourself:
        Write a generic method Pop 
        which returns and removes the first 
        element in a List
        Hint you can use RemoveAt
    */
    public static T Pop<T>(List<T> list)
    {
        T first = list[0];
        list.RemoveAt(0);
        return first;
    }

    /*
        ASIDE
        the `this` keyword here allows you
        to call the method directly on the list. For example:
        myList.PickRandom()
        In other words: it is an extension to the List class
        https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods 
    */
    public static T PickRandomExtension<T>(this List<T> list)
    {
        return list[_rng.Next(list.Count)];
    }
}
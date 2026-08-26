Revision
------------------------ 
- What is an abstract class?
- What is in an abstract class? 
- Can you make an instance of an abstract class?
- Can an abstract class have fields?
- Can an abstract class have a constructor?
- Can a class without abstract members be marked as an abstract class? 
    ```csharp
    public abstract class Animal
    {
        public string Name {get; set;}
    }
    ```
- Must a class with abstract members be marked as an abstract class?
    ```csharp
    public class Animal
    {
        public string Name {get; set;}

        public abstract void Eat(string food);
    }
    ```
- How many abstract classes can a class inherit from?
- Can you inherit from an abstract class and implement an interface as well?
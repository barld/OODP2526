Revision
------------------------ 
- What is an abstract class?
    > An abstract class is a class that cannot be instantiated directly and is designed to be inherited by other classes. It can provide shared data and functionality while requiring derived classes to implement specific members.
- What is in an abstract class? 
    > An abstract class can contain fields, properties, methods, constructors, and virtual and abstract members. Abstract members define a contract that derived classes must implement.
- Can you make an instance of an abstract class?
    > No. Abstract classes cannot be instantiated directly. You must create an instance of a non-abstract class that inherits from the abstract class.
- Can an abstract class have fields?
    > Yes. An abstract class can contain fields just like a regular class and these fields can be used by all derived classes.
- Can an abstract class have a constructor?
    > Yes. An abstract class can have one or more constructors. Although you cannot create an instance of the abstract class itself, its constructor runs when a derived class is instantiated.
- Can a class without abstract members be marked as an abstract class? 
    ```csharp
    public abstract class Animal
    {
        public string Name {get; set;}
    }
    ```
    > Yes. A class can be marked as abstract even if it contains no abstract members. This is often used to prevent the class from being instantiated directly and to indicate that it is intended only as a base class.
- Must a class with abstract members be marked as an abstract class?
    ```csharp
    public class Animal
    {
        public string Name {get; set;}

        public abstract void Eat(string food);
    }
    ```
    > Yes. Any class that contains one or more abstract members must itself be marked as abstract. Otherwise, the code will not compile.
- How many abstract classes can a class inherit from?
    > One. C# does not support multiple inheritance of classes, so a class can inherit from only one class, abstract or not.
- Can you inherit from an abstract class and implement an interface as well?
    > Yes. A class can inherit from one abstract class and implement one or more interfaces at the same time.
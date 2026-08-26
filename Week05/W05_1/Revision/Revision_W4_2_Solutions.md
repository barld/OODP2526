# Revision
## Inheritance
- What does inheritance mean in C#?
    > Inheritance allows one class to reuse (inherit), extend, and modify the functionality of a base class. A derived class inherits fields, properties, methods, and other members from a base class.
- Why would you use inheritance?
    > When you have an "IS-A" relationship and you want to reuse, extend or modify the functionality of a class. 
- What is a `base` class?
    > The class whose members are inherited is called the `base` class.
- What is a derived class?
    > The class that inherits the members of the `base` class is called the derived class.
- How do you denote that a class inherits from another class?
    > After the class definition, use a colon (`:`) followed by the base class name.
    ```csharp
    Student : Person
    ```
- What does `virtual` mean?
   > The `virtual` keyword indicates that a member can be overridden in a derived class, allowing the derived class to provide its own implementation.
- What does `override` mean?
    > The `override` modifier is used in a derived class to provide a new implementation for an inherited virtual (or abstract) member.
- How can I call a method from the base class in the derived class?
    > Use the `base` keyword to access members of the base class.
- How many classes can a class inherit from?
    > Only one base class. C# does not support multiple class inheritance.
- Can you inherit from a class that already inherits from a class?
    > Yes. C# supports multiple levels of inheritance.
- What does the keyword `as` do? What happens if it fails?
   > The `as` operator converts from one type to another type. If the conversion isn't possible, the `as` operator returns `null`. Unlike a cast expression, the `as` operator never throws an exception.
- What does the keyword `is` do?
    > The `is` operator checks if an object is compatible with a given type (is of that type). 
- What does the following code do? Think about the two possible outcomes.
    ```csharp
    if (person is Student test)
    {
        Console.WriteLine(test.StudentID);
    }
    ```
    > It checks whether `person` is a `Student`. If it is, `person` is cast to a `Student` and stored in `test`, and the `StudentID` is printed. If it is not a `Student`, the code inside the if block is skipped.

## Access modifiers
- What does `public` mean?
    > The member can be accessed from any class that has access to the object.
- What does `private` mean?
    > The member can only be accessed from within the class where it is declared.
- When should you use `private`?
    > The principle of encapsulation states that an object's internal data should be hidden from other classes. Therefore, data should generally be private unless there is a good reason to expose it.
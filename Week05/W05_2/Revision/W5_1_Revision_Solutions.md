Revision
------------------------ 
- What does `public` mean?
    > `public` means a member can be accessed from anywhere.
- What does `private` mean?
    > `private` means a member can only be accessed from within the class that contains it.
- What does `protected` mean?
    > `protected` means a member can be accessed from within the class that contains it and from any class that inherits from it.
- What is a property?
    > A property provides controlled access to data stored in an object. Properties allow you to read and/or modify data while optionally adding validation or other logic.
- what do `get` and `set` mean?
    > `get` defines how a property's value is read, while `set` defines how a property's value is assigned.
- When should I use a property vs a field?
    > Use a property for data that needs to be exposed outside the class. Use a field for internal implementation details that do not require controlled access (`private` data).
- What is wrong with the following code? How can we fix it?
    ```csharp
    protected int Age {
         get => Age;
         private set => Age = Math.Clamp(value, 0, 150);
    }
    ```
    > Both the `get` and `set` accessors access the property itself instead of a field. This causes infinite recursion and eventually a stack overflow. The property should use a backing field instead.
- What is an auto implemented property?
    > An auto-implemented property is a property where the compiler automatically creates the backing field.
- What is a read-only property?
    > A read-only property can be read but cannot be modified through the property because it does not expose a set accessor.
- How can I access the parent implementation of a property from the derived class?
    > Use the `base` keyword to access the implementation defined in the base class.
- How many classes can you inherit from?
    > A class can inherit from only one base class. C# does not support multiple inheritance of classes.
- When should you use inheritance?
    > Use inheritance when there is an IS-A relationship and you want to reuse, extend, or modify the functionality of an existing class.
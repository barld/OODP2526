# Revision
- What is an interface?
    > An interface is a contract that defines what members a class must provide, without specifying how they are implemented.
- What is in an interface? 
    > An interface can contain definitions for properties and methods that implementing classes must provide.
- What visibility do interface members have by default? Why?
    > Interface members are public by default because an interface defines a public contract that must be accessible to any code using the interface.
- Can an interface have fields?
    > No. Interfaces cannot contain instance fields because they define a contract, not object state.
- How many interfaces can a class implement?
    > A class can implement multiple interfaces.
- Can you make an instance of an interface?
    > No. An interface cannot be instantiated because it contains no implementation. You must create an instance of a class that implements the interface.
- When should you use an interface?
    > Use an interface when multiple (unrelated) classes need to follow the same contract
- When should you use inheritance vs an interface? 
    > Use inheritance when there is an IS-A relationship and you want to share or extend implementation. Use an interface when classes only need to follow the same contract or capability.
- What is a static class?
    > A static class is a class that contains only static members and is used to group functionality that does not belong to a specific object.
- Can you make an instance of a static class?
    > No. Static classes cannot be instantiated because they are designed to be accessed directly through the class name.
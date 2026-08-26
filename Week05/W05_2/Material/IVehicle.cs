/*
    Interfaces
    ------------------------  
    * An interface defines a contract: 
      a group of related methods and properties
      that an implementing class must implement. 
    * A class can implement multiple interfaces 
      which is important because C# doesn't support 
      multiple inheritance of classes. 
    * Interface properties define what properties
      an implementing class must provide.
      For example: string Name { get;}
      does not create a property. It specifies that
      any implementing class must provide a property
      called Name with at least a get accessor (but it 
      could also have a set).
    * Method signatures indicate the methods that an 
      implementing class must implement. 
    * All members of an interface are public by default, 
      so you do not need to write public.
    * Naming conventions
      - Prefix interface names with I.
      - Use descriptive noun, noun phrase, or 
        adjective phrases. 
      - For example:
        > IComponent (descriptive noun), 
        > ICustomAttributeProvider (noun phrase), 
        > IPersistable (adjective) 
    * A class that implements an interface must provide 
        - implementations for the properties.
        - implementations for the methods.
        (Unless the class is abstract.)
    * Use an interface when 
        - You kind of want multiple inheritance 
          (you can implement multiple interfaces),
        - Several classes have similar public properties,
        - You want several classes to do something similar, 
          but the implementation for each is different,
        - You want to work with objects through a
          common type, for example: List<IPayable>. 

    Now let's translate all that into 7 lines of code....including curly brackets!
    IVehicle
    Properties: Make and Year
    Methods: Start() and Stop()
*/

public interface IVehicle
{
    string Make { get; }
    int Year { get; set; }

    void Start();
    void Stop();
}
/*
Car should inherit from Product

Car should implement IVehicle
Year should not be less than 1886
It should have a IsEngineStarted property that is set in Start() Stop()
Start: "Insert key, start engine"
Stop: "Break, turn off engine"

Car should also implement IRental
StartRental: If not rented set current CurrentRenter to given person
if they have a drivers license
EndRental: Set to null
*/

public class Car : Product, IRental, IVehicle
{
    public bool IsEngineStarted { get; private set; }

    public string Make { get;}
    private int _year;
    public int Year
    { 
        get => _year; 
        set => _year = Math.Max(1886, value); 
    }

    public Person? CurrentRenter { get; set; }
    public bool IsRented { get => CurrentRenter != null; }

    public Car(string make, int year, double price) : base($"{make} Car", price)
    {
        Make = make;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Insert key, start engine");
        IsEngineStarted = true;
    }

    public void Stop()
    {
        Console.WriteLine("Break, turn off engine");
        IsEngineStarted = false;
    }

    public void StartRental(Person person)
    {
        if (!IsRented && person.HasDriverLicense)
        {
            CurrentRenter = person;
        }
    }

    public void EndRental()
    {
        CurrentRenter = null;
    }
}
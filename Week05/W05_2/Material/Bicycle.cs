/*
Bicycle should implement IVehicle
Year should not be less than 1817
It should have a HasHandBreak property 
Start: "Start pedalling"
Stop: "Stop pedalling, pull the break" or "Pedal backwards"

Bicycle should also implement IRental
StartRental: If not rented set current CurrentRenter to given person
EndRental: Set to null
*/
public class Bicycle : IVehicle, IRental
{
    public string Make { get; }
    private int _year;

    public int Year
    {
        get => _year;
        set => _year = Math.Max(1817, value);
    }

    public bool HasHandBreak { get; set; }

    public Person? CurrentRenter { get; set; }

    // public bool IsRented { get => CurrentRenter != null; } // Longer
    public bool IsRented => CurrentRenter != null; // Shorter
    public Bicycle(string make, int year, bool hasHandBreak)
    {
        Make = make;
        Year = year;
        HasHandBreak = hasHandBreak;
    }

    public void Start()
    {
        Console.WriteLine("Start pedalling");
    }

    public void Stop()
    {
        if (HasHandBreak)
            Console.WriteLine("Stop pedalling, pull the break");
        else
            Console.WriteLine("Pedal backwards");
    }

    public void StartRental(Person renter)
    {
        if (!IsRented)
        {
            CurrentRenter = renter;
        }
    }

    public void EndRental()
    {
        CurrentRenter = null;
    }
}

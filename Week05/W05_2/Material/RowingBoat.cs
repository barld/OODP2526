/*
RowingBoat should implement IVehicle
Start: "Start rowing"
Stop: "Stop rowing"
*/
public class RowingBoat : IVehicle
{
    // Notice that setting the property is allowed 
    // even though the setter is not defined in the 
    // interface.
    public string Make { get; set; }
    public int Year { get; set; }

    public RowingBoat(string make, int year)
    {
        Make = make;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Start rowing");
    }

    public void Stop()
    {
        Console.WriteLine("Stop rowing");
    }
}
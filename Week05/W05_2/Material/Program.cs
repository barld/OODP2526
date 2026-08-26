/*
    Code is heavily based on video by IAmTimCorey: 
    https://www.youtube.com/watch?v=4sxyDXt1igs
    Highly recommended watch!
    
    Order:
    ------------------------------
    - IVehicle: Introduce interfaces
    - RowingBoat: Implementation example
    - IRental: Student exercise
    - Bicycle: Multiple interfaces example
    - Car: Student exercise
    - Program: Interfaces as a type
*/
public class Program
{
    static void Main()
    {
        // Cannot create an instance of an interface
        // IVehicle iv = new IVehicle(); //Error
        Car c1 = new Car("Fiat", 2022, 15_000);
        // Car is a Product
        Product c2 = new Car("Fiat", 2022, 15_000);
        // Car implements the IVehicle and IRental contracts
        IVehicle c3 = new Car("Fiat", 2022, 15_000);
        IRental c4 = new Car("Fiat", 2022, 15_000);

        // We can store IVehicles together
        List<IVehicle> myVehicleCollection = new List<IVehicle>{
            new Car("Fiat", 2022, 15_000),
            new Bicycle("Gazelle", 2024, true),
            new Bicycle("OV", 2000, false),
            new RowingBoat("Row row", 0),
            new Car("Ferrari", 2009, 20_000),
            new Bicycle("Gazelle", 1888, true)
        };
        foreach (IVehicle vehicle in myVehicleCollection)
        {
            // We can have methods which take in IVehicles
            TestVehicle(vehicle);
        }

        List<IRental> rentals = new List<IRental>{
            new Bicycle("OV", 2000, false),
            new Bicycle("Gazelle", 1888, true),
            new Car("Lamborghini", 2022, 100_000),
            new Car("Kia", 1989, 20_000)
        };
        foreach (var rental in rentals)
        {
            rental.StartRental(new Person("Fred", true));
            rental.EndRental();
        }
    }

    public static void TestVehicle(IVehicle vehicle)
    {
        vehicle.Start();
        vehicle.Stop();
    }
}
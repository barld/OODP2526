public class Car
{
    public string Brand;
    public int Mileage;

    public Car(string brand)
    {
        Brand = brand;
        Mileage = 0; 
    }

    public void Drive() => Mileage++;

    // Override ToString 
    public override string ToString()
    {
        return $"Brand: {Brand}, Mileage: {Mileage} km";
    }
}
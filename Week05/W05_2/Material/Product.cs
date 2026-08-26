public class Product
{
    public string Name;
    private double _price;

    public double Price
    { 
        get => _price; 
        set => _price = Math.Max(0, value); 
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
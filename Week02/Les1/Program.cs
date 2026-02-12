
public class Menu
{
    public Dictionary<string, string> MenuItems = new ();
    public Menu()
    {
        
    }

    public bool HasMenuOptionAvailable(string key)
    {
        return MenuItems.ContainsKey(key);
    }

    // public string GetMenuItem(string key)
    // {
    //     if (HasMenuOptionAvailable(key))
    //     {
    //         return MenuItems[key];
    //     }
    // }

    public void PrintMenu()
    {
        foreach(var item in this.MenuItems)
        {
            Console.WriteLine($"{item.Key}) {item.Value}");
        }
    }

    public int AmountOfMenuItems() => MenuItems.Count;

    

    
}

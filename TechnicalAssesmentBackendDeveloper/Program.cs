class Program
{
     //private List<String> items = new List<String>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");

        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        List<string> items = new List<string>();
        // This will throw a NullReferenceException
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        manager.RemoveItem("Apple");

        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        // TODO: Implement this part three.
        ItemManager<Fruit> fruitManager = new ItemManager<Fruit>();
        fruitManager.AddItem(new Fruit("Durian"));
        fruitManager.AddItem(new Fruit("Starfruit"));
        fruitManager.AddItem(new Fruit("Watermelon"));

        fruitManager.PrintAllItems();

        // Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
        // TODO: Implement this part four.
        IItemManager InterfaceManager = new ItemManager();
        InterfaceManager.AddItem("Mango");
        InterfaceManager.AddItem("Rambutan");
        InterfaceManager.PrintAllItems();
    }
}

public interface IItemManager
{
    void AddItem(string item);
    void PrintAllItems();
    void RemoveItem(string item);
}

public class Fruit
{
    private string name;

    public Fruit(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public override string ToString()
    {
        return name;
    }
}

public class ItemManager
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Part Two: Implement the RemoveItem method
    // TODO: Implement this method
    public void RemoveItem(string item)
    {
         if (items.Remove(item))
         {
               Console.Writeline(item + "removed.");
         }
         else
         {
               Console.WriteLine(item + "not found.");
         }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

public class ItemManager<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

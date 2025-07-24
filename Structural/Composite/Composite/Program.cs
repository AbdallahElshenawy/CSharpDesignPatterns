/// <summary>
/// The 'Component' interface
/// </summary>
public interface Component
{
    void Display(int depth);
}
/// <summary>
/// The 'Composite' class
/// </summary>
public class Composite : Component
{
    private string name;
    public Composite(string name)
    {
        this.name = name;
    }
    List<Component> children = new List<Component>();
    public void Add(Component component)
    {
        children.Add(component);
    }
    public void Remove(Component component)
    {
        children.Remove(component);
    }
    public void Display(int depth)
    {
        Console.WriteLine(new string(' ', depth * 2) + name);

        // Recursively display child nodes
        foreach (Component component in children)
        {
            component.Display(depth + 2);
        }
    }
}
/// <summary>
/// The 'Leaf' class
/// </summary>
public class Leaf : Component
{
    private string name;

    public Leaf(string name)
    {
        this.name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string(' ', depth * 2) + name);
    }
}
/// <summary>
/// Composite Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create a tree structure
        Composite root = new Composite("Root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));
        Composite compositeX = new Composite("Composite X");
        compositeX.Add(new Leaf("Leaf XA"));
        compositeX.Add(new Leaf("Leaf XB"));
        root.Add(compositeX);
        Composite compositeY = new Composite("Composite Y");
        compositeY.Add(new Leaf("Leaf YA"));
        root.Add(compositeY);

        // Display the tree structure
        root.Display(0);
    }
}



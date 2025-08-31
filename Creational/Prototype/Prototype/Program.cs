/// <summary>
/// Prototype Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create two instances and clone each

        ConcretePrototype1 p1 = new ConcretePrototype1("I");
        ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        Console.WriteLine("Cloned: {0}", c1.Id);

        ConcretePrototype2 p2 = new ConcretePrototype2("II");
        ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
        Console.WriteLine("Cloned: {0}", c2.Id);
    }
}

/// <summary>
/// The 'Prototype' abstract class
/// </summary>

public abstract class Prototype
{
    string id;
    public Prototype(string id)
    {
        this.id = id;
    }

    public string Id
    {
        get { return id; }
    }

    public abstract Prototype Clone();
}

/// <summary>
/// A 'ConcretePrototype' class 
/// </summary>

public class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(string id) : base(id)
    {
    }

    // Returns a shallow copy

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

/// <summary>
/// A 'ConcretePrototype' class 
/// </summary>

public class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(string id) : base(id)
    {
    }
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

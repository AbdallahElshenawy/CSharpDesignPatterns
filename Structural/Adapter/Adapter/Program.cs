
/// <summary>
/// Adapter Design Pattern
/// </summary>

public class Program
{
    public static void Main(string[] args)
    {
        // Create adapter and place a request

        Target target = new Adapter();
        target.Request();
    }

}

/// <summary>
/// The 'Target' class
/// </summary>

public class Target
{
    public virtual void Request()
    {
        Console.WriteLine("Called Target Request()");
    }
}

/// <summary>
/// The 'Adapter' class
/// </summary>

public class Adapter : Target
{
    private Adaptee adaptee = new Adaptee();

    public override void Request()
    {
        // Possibly do some other work
        // and then call SpecificRequest

        adaptee.SpecificRequest();
    }
}

/// <summary>
/// The 'Adaptee' class
/// </summary>

public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

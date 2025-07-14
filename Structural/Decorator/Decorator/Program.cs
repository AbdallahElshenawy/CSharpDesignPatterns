/// <summary>
/// Component Interface
/// </summary>
public interface IComponent
{
    void Operation();
}

/// <summary>
/// Concrete Component
/// </summary>
public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation");
    }
}

/// <summary>
/// Base Decorator class (implements the interface and wraps a component)
/// </summary>
public class Decorator(IComponent component) : IComponent
{
    public virtual void Operation()
    {
        component.Operation();
    }
}

/// <summary>
/// Concrete Decorator A
/// </summary>
public class DecoratorA(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("DecoratorA.Operation");
    }
}

/// <summary>
/// Concrete Decorator B
/// </summary>
public class DecoratorB(IComponent component) : Decorator(component)
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("DecoratorB.Operation");
    }
}

/// <summary>
/// Client Code
/// </summary>
public class Program
{
    public static void Main()
    {
        IComponent component = new ConcreteComponent();
        Console.WriteLine("=== Original ===");
        component.Operation();

        Console.WriteLine("\n=== With DecoratorA ===");
        component = new DecoratorA(component);
        component.Operation();

        Console.WriteLine("\n=== With DecoratorB ===");
        component = new DecoratorB(component);
        component.Operation();

        Console.ReadKey();
    }
}

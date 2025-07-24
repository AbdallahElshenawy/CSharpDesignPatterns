/// <summary>
/// Facade Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Facade facade = new Facade();
        facade.MethodA();
        facade.MethodB();
    }
}
/// <summary>
/// The 'Subsystem ClassA' class
/// </summary>
public class SubSystemOne
{
    public void MethodOne()
    {
        Console.WriteLine(" SubSystemOne Method");
    }
}
/// <summary>
/// The 'Subsystem ClassB' class
/// </summary>
public class SubSystemTwo
{
    public void MethodTwo()
    {
        Console.WriteLine(" SubSystemTwo Method");
    }
}
/// <summary>
/// The 'Subsystem ClassC' class
/// </summary>
public class SubSystemThree
{
    public void MethodThree()
    {
        Console.WriteLine(" SubSystemThree Method");
    }
}
/// <summary>
/// The 'Facade' class
/// </summary>
public class Facade
{
    SubSystemOne one;
    SubSystemTwo two;
    SubSystemThree three;
    public Facade()
    {
        one = new SubSystemOne();
        two = new SubSystemTwo();
        three = new SubSystemThree();
    }
    public void MethodA()
    {
        Console.WriteLine("\nMethodA() ---- ");
        one.MethodOne();
        two.MethodTwo();
        three.MethodThree();
    }
    public void MethodB()
    {
        Console.WriteLine("\nMethodB() ---- ");
        two.MethodTwo();
        three.MethodThree();
    }
}
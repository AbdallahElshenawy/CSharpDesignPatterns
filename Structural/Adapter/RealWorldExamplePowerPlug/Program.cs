/// <summary>
/// Adapter Design Pattern
/// </summary>class Program
public class Program
{
    static void Main(string[] args)
    {
        EuropeanPlug europeanPlug = new EuropeanPlug();
        IUSPowerSocket adapter = new EUToUSAdapter(europeanPlug);

        LaptopCharger charger = new LaptopCharger(adapter);
        charger.Charge();
    }
}

// Target interface (the client expects this)
public interface IUSPowerSocket
{
    void PlugInUS();
}

// Adaptee (incompatible interface)
public class EuropeanPlug
{
    public void PlugInEU()
    {
        Console.WriteLine("European plug is connected.");
    }
}

// Adapter (makes the European plug compatible with US socket)
public class EUToUSAdapter : IUSPowerSocket
{
    private readonly EuropeanPlug _europeanPlug;

    public EUToUSAdapter(EuropeanPlug europeanPlug)
    {
        _europeanPlug = europeanPlug;
    }

    public void PlugInUS()
    {
        Console.WriteLine("Adapter converts US socket to EU plug...");
        _europeanPlug.PlugInEU();
    }
}

// Client
public class LaptopCharger
{
    private readonly IUSPowerSocket _powerSocket;

    public LaptopCharger(IUSPowerSocket powerSocket)
    {
        _powerSocket = powerSocket;
    }

    public void Charge()
    {
        Console.WriteLine("Laptop charger is ready to use.");
        _powerSocket.PlugInUS();
    }
}


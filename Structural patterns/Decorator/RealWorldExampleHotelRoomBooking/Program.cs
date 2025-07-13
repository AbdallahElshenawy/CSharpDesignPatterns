/// <summary>
/// Entry point demonstrating the Decorator Design Pattern
/// in a hotel booking context.
/// </summary>
public class Program
{
    public static void Main()
    {
        IRoom booking = new StandardRoom();

        Console.WriteLine($"Original: {booking.GetDescription()} | Cost: LE {booking.GetCost()}");

        booking = new Breakfast(booking);
        booking = new SpaAccess(booking);
        booking = new AirportPickup(booking);

        Console.WriteLine($"\nCustomized: {booking.GetDescription()}");
        Console.WriteLine($"Total Cost: LE {booking.GetCost()}");

        Console.ReadKey();
    }
}

/// <summary>
/// The base interface for room booking functionality.
/// </summary>
public interface IRoom
{
    string GetDescription();
    decimal GetCost();
}

/// <summary>
/// A basic concrete room without any add-ons.
/// </summary>
public class StandardRoom: IRoom
{
    public string GetDescription() => "Standard Room";
    public decimal GetCost() => 100.00m;
}

/// <summary>
/// Abstract base decorator for adding services to a room.
/// </summary>
public abstract class RoomDecorator(IRoom room) : IRoom
{
    public virtual string GetDescription() => room.GetDescription();
    public virtual decimal GetCost() => room.GetCost();
}

/// <summary>
/// Adds breakfast to a room booking.
/// </summary>
public class Breakfast(IRoom room) : RoomDecorator(room)
{
    public override string GetDescription() => room.GetDescription() + ", with Breakfast";
    public override decimal GetCost() => room.GetCost() + 25.00m;
}

/// <summary>
/// Adds spa access to a room booking.
/// </summary>
public class SpaAccess(IRoom room) : RoomDecorator(room)
{
    public override string GetDescription() => room.GetDescription() + ", Spa Access";
    public override decimal GetCost() => room.GetCost() + 50.00m;
}

/// <summary>
/// Adds airport pickup service to a room booking.
/// </summary>
public class AirportPickup(IRoom room) : RoomDecorator(room)
{
    public override string GetDescription() => room.GetDescription() + ", Airport Pickup";
    public override decimal GetCost() => room.GetCost() + 40.00m;
}

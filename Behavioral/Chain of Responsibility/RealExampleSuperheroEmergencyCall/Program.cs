// Request
public class Emergency
{
    public string Description { get; }
    public Emergency(string description)
    {
        Description = description;
    }
}

// Handler Interface
public abstract class Superhero
{
    protected Superhero nextHero;

    public void SetNext(Superhero next)
    {
        nextHero = next;
    }

    public abstract void HandleEmergency(Emergency emergency);
}

// Concrete Handlers
public class Batman : Superhero
{
    public override void HandleEmergency(Emergency emergency)
    {
        if (emergency.Description.Contains("robbery", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($" Batman: I'll handle the {emergency.Description}!");
        }
        else
        {
            Console.WriteLine(" Batman: This isn't my specialty... passing it on.");
            nextHero?.HandleEmergency(emergency);
        }
    }
}

public class Aquaman : Superhero
{
    public override void HandleEmergency(Emergency emergency)
    {
        if (emergency.Description.Contains("flood", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($" Aquaman: I'll handle the {emergency.Description}!");
        }
        else
        {
            Console.WriteLine(" Aquaman: Not my kind of battle... passing it on.");
            nextHero?.HandleEmergency(emergency);
        }
    }
}

public class Superman : Superhero
{
    public override void HandleEmergency(Emergency emergency)
    {
        if (emergency.Description.Contains("alien", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($" Superman: I'll save the day from the {emergency.Description}!");
        }
        else
        {
            Console.WriteLine(" Superman: Even I can't handle this... passing it on.");
            nextHero?.HandleEmergency(emergency);
        }
    }
}

public class NoHeroAvailable : Superhero
{
    public override void HandleEmergency(Emergency emergency)
    {
        Console.WriteLine($" No hero available for: {emergency.Description} - Mission Impossible!");
    }
}
class Program
{
    static void Main()
    {
        // Create heroes
        var batman = new Batman();
        var aquaman = new Aquaman();
        var superman = new Superman();
        var noHero = new NoHeroAvailable();

        // Set the chain
        batman.SetNext(aquaman);
        aquaman.SetNext(superman);
        superman.SetNext(noHero);

        // Incoming emergencies
        batman.HandleEmergency(new Emergency("Robbery at the bank"));
        Console.WriteLine();

        batman.HandleEmergency(new Emergency("Flood in downtown"));
        Console.WriteLine();

        batman.HandleEmergency(new Emergency("Alien invasion in the city"));
        Console.WriteLine();

        batman.HandleEmergency(new Emergency("Giant meteor falling on Earth"));
    }
}

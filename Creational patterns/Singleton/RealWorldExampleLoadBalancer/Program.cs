public class Program
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public static void Main()
    {
        var b1 = LoadBalancer.GetLoadBalancer();
        var b2 = LoadBalancer.GetLoadBalancer();
        var b3 = LoadBalancer.GetLoadBalancer();
        var b4 = LoadBalancer.GetLoadBalancer();

        if (b1 == b2 && b2 == b3 && b3 == b4)
        {
            Console.WriteLine("Same instance\n");
        }

        var balancer = LoadBalancer.GetLoadBalancer();
       
        for (int i = 0; i < 15; i++)
        {
            var server = balancer.NextServer.Name;
            Console.WriteLine("Dispatch request to: " + server);
        }
        Console.ReadKey();
    }
}

/// <summary>
/// The 'Singleton' class
/// </summary>
public sealed class LoadBalancer
{
    // .NET guarantees thread safety for static initialization
    private static readonly LoadBalancer instance = new();

    private readonly List<Server> servers;
    private readonly Random random = new();

    private LoadBalancer()
    {
        servers = [
                    new(Name: "ServerI", Ip: "120.14.220.18"),
                    new(Name: "ServerII", Ip: "120.14.220.19" ),
                    new(Name: "ServerIII", Ip: "120.14.220.20" ),
                    new(Name: "ServerIV", Ip: "120.14.220.21" ),
                    new(Name: "ServerV", Ip: "120.14.220.22" )
                  ];
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return instance;
    }

    public Server NextServer
    {
        get => servers[random.Next(servers.Count)];
    }
}
public record Server(string Name, string Ip);

/// <summary>
/// Facade Design Pattern
/// </summary>
public class Program
{
    static void Main()
    {
        var mortgage = new Mortgage();
        var customer = new Customer("Abdallah");
        bool eligible = mortgage.IsEligible(customer, 100000);

        string result = eligible ? "Approved" : "Rejected";
        Console.WriteLine($"\n{customer.Name} has been {result}");
    }
}

/// <summary>
/// The 'Subsystem ClassA' class
/// </summary>
public class Bank
{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.WriteLine($"Check bank for {c.Name}");
        return true;
    }
}
/// <summary>
/// The 'Subsystem ClassB' class
/// </summary>
public class Credit
{
    public bool HasGoodCredit(Customer c)
    {
        Console.WriteLine($"Check credit for {c.Name}");
        return true;
    }
}
/// <summary>
/// The 'Subsystem ClassC' class
/// </summary>
public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
        Console.WriteLine($"Check loans for {c.Name}");
        return true;
    }
}

/// <summary>
/// The 'Facade' class
/// </summary>
public class Mortgage
{
    private readonly Bank bank = new();
    private readonly Loan loan = new();
    private readonly Credit credit = new();

    public bool IsEligible(Customer cust, int amount)
    {
        Console.WriteLine("{0} applies for {1:C} loan\n",
            cust.Name, amount);

        bool eligible = true;

        if (!bank.HasSufficientSavings(cust, amount))
        {
            eligible = false;
        }
        else if (!loan.HasNoBadLoans(cust))
        {
            eligible = false;
        }
        else if (!credit.HasGoodCredit(cust))
        {
            eligible = false;
        }

        return eligible;
    }
}

/// <summary>
/// Customer class
/// </summary>
public record Customer(string Name);

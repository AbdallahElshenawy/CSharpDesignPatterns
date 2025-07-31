/// <summary>
/// Iterator Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        ConcreteAggregate a = new ConcreteAggregate();
        a[0] = "Item A";
        a[1] = "Item B";
        a[2] = "Item C";
        a[3] = "Item D";

        // Create Iterator and provide aggregate

        Iterator i = a.CreateIterator();

        Console.WriteLine("Iterating over collection:");

        object item = i.First();

        while (item != null)
        {
            Console.WriteLine(item);
            item = i.Next();
        }
    }
}

/// <summary>
/// The 'Aggregate' abstract class
/// </summary>

public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>

public class ConcreteAggregate : Aggregate
{
    List<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return items.Count; }
    }

    // Indexer
    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

/// <summary>
/// The 'Iterator' abstract class
/// </summary>
public abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

/// <summary>
/// The 'ConcreteIterator' class
/// </summary>
public class ConcreteIterator : Iterator
{
    ConcreteAggregate aggregate;
    int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public override object First()
    {
        return aggregate[0];
    }
    public override object Next()
    {
        object toReturn = null;
        if (current < aggregate.Count - 1)
        {
            toReturn = aggregate[++current];
        }

        return toReturn;
    }
    public override object CurrentItem()
    {
        return aggregate[current];
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}

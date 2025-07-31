using System.Collections;

/// <summary>
/// Iterator Design Pattern
/// </summary>
public class Program
{
    public static void Main()
    {
        ItemCollection<Item> items = [
                new("Item 0"),
                new("Item 1"),
                new("Item 2"),
                new("Item 3"),
                new("Item 4"),
                new("Item 5"),
                new("Item 6"),
                new("Item 7"),
                new("Item 8")
              ];

        Console.WriteLine("Iterate front to back");
        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\nIterate back to front");
        foreach (var item in items.BackToFront)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\nIterate range (1-7) in steps of 2");
        foreach (var item in items.FromToStep(1, 7, 2))
        {
            Console.WriteLine(item.Name);
        }

    }
}

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>
/// <typeparam name="T">Collection item type</typeparam>
public class ItemCollection<T> : IEnumerable<T>
{
    private readonly List<T> items = [];

    public void Add(T t) => items.Add(t);

    // The 'ConcreteIterator'
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }
    public IEnumerable<T> FrontToBack { get => this; }

    public IEnumerable<T> BackToFront
    {
        get
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
    }

    public IEnumerable<T> FromToStep(int from, int to, int step)
    {
        for (int i = from; i <= to; i += step)
        {
            yield return items[i];
        }
    }
    public int Count { get => items.Count; }

    // System.Collections.IEnumerable member implementation
    // Required for non-generic IEnumerable
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
/// <summary>
/// The collection item
/// </summary>
public record Item(string Name);

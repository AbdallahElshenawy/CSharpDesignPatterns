/// <summary>
/// The 'Component' Abstract Class
/// </summary>
public abstract class CourseComponent
{
    public string Title { get; set; }

    public CourseComponent(string title)
    {
        Title = title;
    }

    public abstract void Display(int depth);
}
/// <summary>
/// The 'Leaf' class
/// </summary>
public class Lesson : CourseComponent
{
    public Lesson(string title) : base(title) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "Lesson: " + Title);
    }
}
/// <summary>
/// The 'Leaf' class
/// </summary>
public class Quiz : CourseComponent
{
    public Quiz(string title) : base(title) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "Quiz: " + Title);
    }
}

/// <summary>
/// The 'Composite' class
/// </summary>
public class Module : CourseComponent
{
    List<CourseComponent> _components = new();

    public Module(string title) : base(title) { }

    public void Add(CourseComponent component)
    {
        _components.Add(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Module: " + Title);
        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
}
/// <summary>
/// The 'Composite' class
/// </summary>
public class Course : CourseComponent
{
    List<CourseComponent> _components = new();

    public Course(string title) : base(title) { }

    public void Add(CourseComponent component)
    {
        _components.Add(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Course: " + Title);
        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var course = new Course("C# Masterclass");

        var module1 = new Module("Introduction To C#");
        module1.Add(new Lesson("What is C#?"));
        module1.Add(new Lesson("Setting up your environment"));
        module1.Add(new Quiz("Intro Quiz"));

        var module2 = new Module("OOP in C#");
        module2.Add(new Lesson("Classes and Objects"));
        module2.Add(new Lesson("Inheritance"));
        module2.Add(new Quiz("OOP Quiz"));

        course.Add(module1);
        course.Add(module2);

        course.Display(0);
    }
}


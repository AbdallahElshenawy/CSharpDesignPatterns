public class Program
{
    public static void Main()
    {
        // Document constructors call Factory Method
        List<Document> documents = [new Resume(), new Report()];
      
        foreach (var document in documents)
        {
            document.CreatePages();  
            Console.WriteLine($"{document} --");
            foreach (var page in document.Pages)
                Console.WriteLine($" {page}");
          
        }
    }
}
/// <summary>
/// The 'Product' abstract class
/// </summary>
public abstract class Page
{
    public override string ToString() => GetType().Name;
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class SkillsPage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class EducationPage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class ExperiencePage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class IntroductionPage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>    
public class ResultsPage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class ConclusionPage : Page
{
}
/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class SummaryPage : Page
{
}
/// <summary>
/// The 'Creator' abstract class
/// </summary>
public abstract class Document
{
    // Gets list of document pages
    public List<Page> Pages { get; protected set; } = null!;
    // Factory Method
    public abstract void CreatePages();
    public override string ToString() => GetType().Name;
}
/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class Resume : Document
{
    public override void CreatePages()
    {
        Pages =
        [
            new SkillsPage(),
            new EducationPage(),
            new ExperiencePage()
                 ];
    }
}
/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class Report : Document
{
    public override void CreatePages()
    {
        Pages =
        [
            new IntroductionPage(),
            new ResultsPage(),
            new SummaryPage(),
            new ConclusionPage()
                 ];
    }
}
namespace Observer.Structural
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            // Change subject's state and notify
            subject.SubjectState = "ABC";
            subject.Notify();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Subject
    {
        private readonly List<Observer> _observers = new();

        public void Attach(Observer observer) => _observers.Add(observer);
        public void Detach(Observer observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; } = string.Empty;
    }

    /// <summary>
    /// The 'Observer' abstract class
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class ConcreteObserver : Observer
    {
        public string Name { get; }
        public string ObserverState { get; private set; }

        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            Name = name;
        }

        public override void Update()
        {
            ObserverState = _subject.SubjectState;
            Console.WriteLine($"Observer {Name}'s new state is {ObserverState}");
        }
    }
}

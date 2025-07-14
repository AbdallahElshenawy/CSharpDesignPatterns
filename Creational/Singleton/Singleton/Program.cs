using System;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            if (instance1 == instance2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            else
            {
                Console.WriteLine(" Objects are different instances");
            }

            Console.ReadKey();
        }
    }

    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new();
        private Singleton() { }
   
        public static Singleton Instance
        {
            get
            {
                lock (_lock) // Ensure thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}

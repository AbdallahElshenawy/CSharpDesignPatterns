namespace Observer.OnlineCourse
{
    public class Program
    {
        public static void Main()
        {
            var csharpCourse = new Course("Mastering C#");

            var student1 = new Student("Abdallah");
            var student2 = new Student("Ahmed");

            csharpCourse.Subscribe(student1);
            csharpCourse.Subscribe(student2);
 
            csharpCourse.UploadLecture("Observer Pattern Deep Dive");

            csharpCourse.Unsubscribe(student2);

            csharpCourse.UploadLecture("Strategy Pattern in Real Projects");

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Subject class - Course
    /// Notifies all subscribed students when a new lecture is uploaded.
    /// </summary>
    public class Course(string coursenName) 
    {
        private readonly List<IStudent> _subscribers = new();
        public void Subscribe(IStudent student)
        {
            _subscribers.Add(student);
            Console.WriteLine($"{student.Name} subscribed to \"{coursenName}\"");
        }
        public void Unsubscribe(IStudent student)
        {
            _subscribers.Remove(student);
            Console.WriteLine($"{student.Name} unsubscribed from \"{coursenName}\"");
        }
        public void UploadLecture(string lectureTitle)
        {
            Console.WriteLine($"\nNew lecture uploaded to \"{coursenName}\": {lectureTitle}");
            NotifyStudents(lectureTitle);
        }

        private void NotifyStudents(string lectureTitle)
        {
            foreach (var student in _subscribers)
            {
                student.Notify(coursenName, lectureTitle);
            }
        }
    }

    /// <summary>
    /// Observer interface - all students implement this
    /// </summary>
    public interface IStudent
    {
        string Name { get; }
        void Notify(string courseName, string lectureTitle);
    }

    /// <summary>
    /// Concrete observer - Student
    /// </summary>
    public class Student(string name) : IStudent
    {
        public string Name { get; } = name;
        public void Notify(string courseName, string lectureTitle)
        {
            Console.WriteLine($"{Name} received notification: \"{lectureTitle}\" in course \"{courseName}\"");
        }
    }
}

namespace Excercise5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running, Program!");

        Student std = new Student("John Doe", 20, "Computer Science");

        std.Introduce();

        Console.ReadKey();
    }
}


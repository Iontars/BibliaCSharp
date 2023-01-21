using static System.Console;
namespace Chapter_4;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Matrix has you";
        string fullpath = Environment.GetCommandLineArgs()[0];
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(fullpath);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hello, World!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Console.BufferHeight} + {Console.BufferWidth}");

        //ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };
        foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
        {
            Console.CursorLeft = (Console.BufferWidth - color.ToString().Length) / 2;
            Console.CursorTop = (Console.BufferHeight / 2);
            Console.ForegroundColor = color;
            Console.WriteLine(color);
            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.ReadLine();
        Console.Clear();
    }
}


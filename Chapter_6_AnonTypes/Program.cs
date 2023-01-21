namespace Chapter_6_AnonTypes;
class Program
{
    static void Main(string[] args)
    {
        var p = new
        {
            FirstName = "Den",
            LastName = "Sharp",
            Age = 20
        };

        Console.WriteLine(p.Age);

    }
}


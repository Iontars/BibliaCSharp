namespace Chapter_6_Tuple;
class Program
{
    static void Main(string[] args)
    {
        Tuple<int, int> values = new Tuple<int, int>(10,30);
        Console.WriteLine(values.Item1 + values.Item2);
    }
}


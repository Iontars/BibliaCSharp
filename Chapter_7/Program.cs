namespace Chapter_7;
class Program
{
    static void Main(string[] args)
    {
        Person firstPerson = new();
        firstPerson.AddMoney(500);
        Person secondPerson = (Person)firstPerson.Clone();

        Console.WriteLine(firstPerson.Sum);
        Console.WriteLine(secondPerson.Sum);
    }
}


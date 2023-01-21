using System;

namespace Chapter_3_OOP_Person;
class Program
{
    static void Main(string[] args)
    {
        Person p = new("Ден", "Восьмой");
        Console.WriteLine(((Object)p).ToString()); // overrided
        Console.WriteLine(p.ToString()); // overrided
        Console.WriteLine(p.GetType().Name); // имя класса

        Person obj = p;
        Console.WriteLine(obj.ToString()); // так как метод ToString override и не new 

        Person otherPerson = new("Kate","Stars");
        Console.WriteLine(otherPerson.ToString());

        if (obj.Equals(p)) Console.WriteLine("True");
        else Console.WriteLine("False");

        if (otherPerson.Equals(p)) Console.WriteLine("True");
        else Console.WriteLine("False");
    }
}


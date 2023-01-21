using System;
using System.Collections.Generic;

namespace Chapter_8_List;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        Random rnd = new Random();
        int x = 5;
        for (int i = 0; i < x; i++)
        {
            list.Add(rnd.Next(0, 10));
        }
        Console.WriteLine(list[0]);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        if (list.Contains(x))
        {
            Console.WriteLine($"содержит {x}");
        }

    }
}


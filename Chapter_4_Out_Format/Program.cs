namespace Chapter_4_Out_Format;
class Program
{
    static void Main(string[] args)
    {
        int index = 10;

        Console.WriteLine("Первое число {0:c} \nВторое число {1} в 16 формате {1:x} \nТретье число {0:f1}",
                          new object[] {index, index*index});
    }
}


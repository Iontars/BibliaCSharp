using System;
using System.Windows;
using System.Reflection;
namespace Chapter_3;
class Program
{
    
    static void Main(string[] args)
    {
        Shed firstShed = new();
        Shed secondShed = new();
        Shed thirdShed = new();
        Shed fourthShed = new();
        Params @params = new();

        int valueForShed_1 = 3;
        int valueForShed_2 = 5;
        int valueForShed_3 = 12;
        string valueForConstruct;

        firstShed.Width = 10;
        secondShed.Width = 10;
        thirdShed.Width = 10;
        firstShed.Height = 20;
        secondShed.Height = 20;
        thirdShed.Height = 20;
        firstShed.Lenghtwise = firstShed.Width;
        secondShed.Lenghtwise = secondShed.Width;
        thirdShed.Lenghtwise = thirdShed.Width;
        
        string fullpath = Environment.GetCommandLineArgs()[0];
        Console.WriteLine(fullpath);

        firstShed.window.ShutWindow();

        Console.WriteLine("Выбрать число от 1 до 3 ");

        valueForConstruct = Console.ReadLine() ?? "";
        ShedConstruct shedConstruct = new(firstShed.Width, secondShed.Height, 20, valueForConstruct);

        int result = firstShed.GetSize();

        secondShed.ExpandSize(2, 3, 4);
        int result_2 = secondShed.GetSize();

        thirdShed.ExpandTroughSum(ref valueForShed_1,
                                   ref valueForShed_2,
                                   ref  valueForShed_3,
                                   out int result_3);

        fourthShed.SetDimensions(10, 20, 10);
        int result_4 = fourthShed.GetSize();

        int otherResult_5;
        int result_5 = @params.SumAllValues(out otherResult_5, 1, 2,3,4,5,6,7,8,9,10);

        int result_6 = shedConstruct.GetSize(shedConstruct.Width,
                                                   shedConstruct.Height,
                                                   shedConstruct.Lenghtwise);
        
        Console.WriteLine($"Объем сарая #1 равен: {result}");
        Console.WriteLine($"Объем сарая #2 равен: {result_2}");
        Console.WriteLine($"Объем сарая #3 равен: {result_3}");
        Console.WriteLine($"Объем сарая #4 равен: {result_4}");
        Console.WriteLine($"Сумма чисел равна: {result_5}");
        Console.WriteLine($"Сумма чисел равна: {otherResult_5}");
        Console.WriteLine($"Сумма чисел равна: {result_6}");
        Console.WriteLine($"{firstShed.GetObjectsNumber()} экземпляра класса Shed было создано");

        
        
    }
}


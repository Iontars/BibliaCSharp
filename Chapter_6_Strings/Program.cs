namespace Chapter_6_Strings;
class Program
{
    static void Main(string[] args)
    {
        string value_1 = "текста";
        string text = String.Format("Вывод {0} на экран \nТекущее время: {1}", value_1, DateTime.Now);
        text = text.Replace(value_1, "времени");
        text = text.ToUpper();
        Console.WriteLine(text);

        text = text.Remove(5,8);
        Console.WriteLine(text);
    }
}

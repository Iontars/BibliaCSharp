using Chapter_3;
using System.Reflection;

namespace Chapter_6;
class Program
{
    static void Main(string[] args)
    {

        ClassEngine classEngine = new();
        ClassTestReflection classTestReflection = new ClassTestReflection();
        List<int> valuesArray = new List<int>();
        


        //string sameValue = Console.ReadLine()?? "";
        string sameValue = "10";
        string searchableField = "value_4";
        string searchableProperty = "SameProperty";

        
        
        if(Int32.TryParse(sameValue, out int parseResult))
            Console.WriteLine("Верный тип даных {0}",parseResult);
        else Console.WriteLine("Не верный тип даных");

        // Рефлексия
        Type type = typeof(ClassTestReflection);
        PropertyInfo[] propertyInfos = type.GetProperties();
        FieldInfo[] fieldInfos = type.GetFields();
        MethodInfo[] methodInfos = type.GetMethods();

        classEngine.DisplayReflectGeneric(propertyInfos);
        Console.WriteLine();
        classEngine.FindReflect(propertyInfos, type, searchableProperty);
        Console.WriteLine();
        classEngine.DisplayReflectGeneric(fieldInfos);
        Console.WriteLine();
        classEngine.FindReflect(fieldInfos, type, searchableField);

        List<int> results = new();
        int count = default;

        Console.WriteLine($"Исследование класса {classTestReflection.GetType().Name}");
        foreach (var item in fieldInfos)
        {
            //Console.WriteLine(fieldInfos.GetType());
            //Console.WriteLine(item.Name.GetType().Name);            
            if (item?.GetValue(classTestReflection)?.GetType()?.Name == typeof(Int32).Name)
            {
                try
                {
                    results.Add(Convert.ToInt32((item?.GetValue(classTestReflection))));                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);                
                }
                Console.WriteLine("Имя поля: {0}\nПорядковый номер поля: {1}\n" +
                                  "Значение поля: {2}\nТип данныхж: {3}",
                                  item?.Name, count + 1 , results[count++],
                                  item?.GetValue(classTestReflection)?.GetType().Name);
            }           
        }


    }
}


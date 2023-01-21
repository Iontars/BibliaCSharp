using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters;


namespace Chapter_6
{
	public class ClassEngine
	{
        // Generic
        public void DisplayReflectGeneric<T>(T[] array)
        {
            foreach (T item in array)
            {
                if (typeof(T) == typeof(FieldInfo)) Console.WriteLine((item as FieldInfo)?.Name);
                if (typeof(T) == typeof(MethodInfo)) Console.WriteLine((item as MethodInfo)?.Name);
                if (typeof(T) == typeof(PropertyInfo)) Console.WriteLine((item as PropertyInfo)?.Name);
            }
        }

        // Method overload
        public void FindReflect(FieldInfo[] array, Type type, string searchable)
        {
            foreach (var item in array)
            {
                if (item.Name == searchable)
                {
                    Console.WriteLine("{0} contains {1}\n", type.Name, searchable);
                }
            }          
        }

        public void FindReflect(MethodInfo[] array, Type type, string searchable)
        {
            foreach (var item in array)
            {
                if (item.Name == searchable)
                {
                    Console.WriteLine("{0} contains {1}\n", type.Name, searchable);
                }
            }
        }

        public void FindReflect(PropertyInfo[] array, Type type, string searchable)
        {
            foreach (var item in array)
            {
                if (item.Name == searchable)
                {
                    Console.WriteLine("{0} contains {1}\n", type.Name, searchable);
                }
            }
        }


        
	}


}


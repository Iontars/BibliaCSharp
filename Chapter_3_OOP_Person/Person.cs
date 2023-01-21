using System;
using System.Collections;

namespace Chapter_3_OOP_Person
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Person(string firstName, string lastname)
		{
			FirstName = firstName;
			LastName = lastname;
		}

        public override string ToString()
        {
			return FirstName + " " + LastName;
        }

        ArrayList Children = new ArrayList();
        public void AddChild(string firstName, string lastName)
        {
            Children.Add(new Person(firstName, lastName));
        }
        public void DeleteChild(int index)
        {
            Children.RemoveAt(index);
        }
        public Person GetChild(int index)
        {
            return (Person)Children[index];
        }
    }
}


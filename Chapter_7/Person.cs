using System;
namespace Chapter_7
{
	public class Person : iPurse, ICloneable
	{
        int sum = default;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }

        public Person()
        {

        }

        public int Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }

        public void AddMoney(int sum) => Sum += sum;
        public int DecMoney(int sum)
        {
            Sum -= sum;
            return Sum;
        }

        public object Clone()
        {
            Person p = new Person(this.FirstName, this.LastName);
            p.Sum = this.Sum;
            return p;
        }
    }
}


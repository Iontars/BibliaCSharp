using System;
using System.Reflection;

namespace Chapter_6
{
	public class ClassTestReflection
	{
		public int value_1 = -90;
		public string value_2 = "word";
		public int value_3 = 300;
		public int value_4 = 25;

		public int MyProperty_1 { get; set; }
		public int SameProperty { get; set; }

		public int DisplayMessage()
		{
			return 1 + 1;
		}



		public ClassTestReflection()
		{

		}
	}
}


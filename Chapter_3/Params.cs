using System;
namespace Chapter_3
{
	public class Params
	{
		public int SumAllValues(out int otherResult, params int[] values)
		{
			int result = default;
			otherResult = default;
			for (int i = 0; i < values.Length; i++)
			{
				result += values[i];
				otherResult += values[i];
			}

			return result;
		}

		public Params()
		{

		}
	}
}


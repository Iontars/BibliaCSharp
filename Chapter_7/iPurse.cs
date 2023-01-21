using System;
namespace Chapter_7
{
	public interface iPurse
	{
		public int Sum { get; set; }

		void AddMoney(int sum);
		int DecMoney(int sum);
    }
}


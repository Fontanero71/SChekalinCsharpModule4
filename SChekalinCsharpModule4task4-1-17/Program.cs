using System;

namespace SChekalinCsharpModule4task4_1_17
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] {5,6,9,1,2,3,4};
			for (int i = 0; i < arr.Length-1; i++)
            {
				for (int j = i+1; j < arr.Length; j++)
                {
					if (arr[j] < arr[i])
                    {
						int temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
                }
            }
			foreach (int i in arr)
				Console.Write(i);
		}
	}
}
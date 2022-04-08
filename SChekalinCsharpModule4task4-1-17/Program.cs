using System;

namespace SChekalinCsharpModule4task4_1_17
{
	class Program
	{
		public static void Main(string[] args)
		{
			var arr = new int[] {5,6,9,1,2,3,4};
			var sum = 0;
			for (int i = 0; i < arr.Length; i++)
            {
				/*for (int j = i+1; j < arr.Length; j++)
                {
					if (arr[j] < arr[i])
                    {
						int temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
                }*/
				sum += arr[i];
            }
			//foreach (int i in arr)
			Console.Write(sum);
		}
	}
}
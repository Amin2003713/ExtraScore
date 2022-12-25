class _8
{
	public static void Main(string[] args)
	{
		Console.Write("inter how many times u need program to be repeaded : ");
		int repead = Convert.ToInt32(Console.ReadLine());
		Console.Write("inter the x to count from x to 10 : ");
		int x = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < repead; i++)
		{
			CountFrom10ToX(x);
		}
		Console.ReadKey();

	}



	public static void CountFrom10ToX(int x)
	{
		if (x > 10)
		{
			for (int j = 10; j <= x; j++)
			{
				Console.Write($"{j} \t");
			}
		}

		if (x < 10)
		{
			for (int i = x; i <= 10; i++)
			{
				Console.Write($"{i} \t");
			}
		}

		Console.WriteLine();
	}
}
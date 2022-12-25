class _14
{
	public static void Main(string[] args)
	{
		Console.Write("inter x : ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.Write("inter the number of n : ");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"the result is => {GetResult(x, n)}");
		Console.ReadKey();

	}

	public static double GetResult(int x, int n)
	{
		double result = 0;
		for (int i = 1; i <= n; i++)
		{
			if (IsEven(i)) result -= ((double)Pow(x, i) / (double)GetDivider(i));
			if (IsOdd(i)) result += ((double)Pow(x, i) / (double)GetDivider(i));
		}
		return result;
	}

	public static Int64 Pow(int x, int i)
	{
		if (i == 1) return x;
		return x * Pow(x, i - 1);
	}

	public static int GetDivider(int i)
	{
		int result = 1;
		if (i % 2 == 0)
		{
			for (int j = 1; j <= i; j++)
			{
				if (j % 2 == 0 && IsEven(j)) result *= j;
			}
		}

		if (i % 2 != 0)
		{
			for (int j = 1; j <= i; j++)
			{
				if (j % 2 != 0 && IsOdd(j)) result *= j;
			}
		}

		return result;
	}
	public static bool IsOdd(int a)
	{
		return a % 2 != 0;
	}
	public static bool IsEven(int a)
	{
		return a % 2 == 0;
	}
}
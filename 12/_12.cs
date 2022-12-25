// See https://aka.ms/new-console-template for more information
class _12
{
	public static void Main(string[] args)
	{
		Console.Write("inter a number for factor : ");
		long n = Convert.ToInt64(Console.ReadLine());
		Console.Write("inter a number for pow : ");
		int x = Convert.ToInt32(Console.ReadLine());
		double fac = GetResult(n, x);
		Console.WriteLine($"the result is => {fac}");
		Console.ReadKey();



	}

	public static double GetResult(long l, int x)
	{
		double result = 0;
		for (int i = 1; i <= l; i++)
		{
			result += ((double)Pow(x, i) / (double)(GetFactorial(i)));
		}
		return result;
	}

	public static Int64 Pow(int x, int i)
	{
		if (i == 1) return x;
		return x * Pow(x, i - 1);
	}
	public static Int64 GetFactorial(Int64 i)
	{
		if (i == 1)
			return 1;

		return i * GetFactorial(i - 1);
	}
}


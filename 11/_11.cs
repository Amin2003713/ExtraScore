// See https://aka.ms/new-console-template for more information
class _11
{
	public static void Main(string[] args)
	{
		Console.Write("inter a number : ");
		long n = Convert.ToInt64(Console.ReadLine());
		double fac = GetResult(n);
		Console.WriteLine($"the result is => {fac}");
	}

	public static double GetResult(long l)
	{
		double result = 0;
		for (int i = 1; i <= l; i++)
		{
			long a = (GetFactorial(i) != 0) ? GetFactorial(i) : 1;
			result += ((double)i / (double)a);
		}
		return result;
	}


	public static Int64 GetFactorial(Int64 i)
	{
		if (i == 1)
			return 1;

		return i * GetFactorial(i - 1);
	}

}
internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("inter a number : ");
		var n = Convert.ToInt64(Console.ReadLine());
		long fac = GetResult(n);
		Console.WriteLine($"the result is => {fac}");
	}


	public static long GetResult(long l)
	{
		long result = 0;
		for (int i = 1; i <= l; i++)
		{
			result += GetFactorial(i);
		}
		return result;
	}


	public static long GetFactorial(long i)
	{
		if (i == 1)
			return 1;

		return i * GetFactorial(i - 1);
	}
}

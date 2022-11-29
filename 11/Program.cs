// See https://aka.ms/new-console-template for more information
class Program
{
	public static void Main(string[] args)
	{
		Console.Write("inter a number : ");
		var n = Convert.ToInt64(Console.ReadLine());
		double fac = GetResult(n);
		Console.WriteLine($"the result is => {fac}");
		Console.ReadKey();

	}

	public static double GetResult(long l)
	{
		double result = 0;
		for (int i = 1; i <= l; i++)
		{
			result += (i / (GetFactorial(i)));
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
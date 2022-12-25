internal class _15
{
	private static void Main(string[] args)
	{
		Console.Write("Inter x for Log x : ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Inter base for Log x : ");
		int k = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine($"the result of LOG {x} is => {GetLog(x, k)}");
		Console.WriteLine($"                 {k}");
		Console.ReadKey();

	}

	private static double GetLog(int x, int k)
	{
		return Math.Log(x, k);
	}
}
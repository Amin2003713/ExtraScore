namespace _18
{
	internal class _18
	{
		static void Main(string[] args)
		{
			//e^ax repead n times
			Console.Write("inter the number as e : ");
			int e = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter the number as a : ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter the number as n for reapet : ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"the result is {GetDivision(e, a, n)}");
			Console.ReadKey();

		}

		private static double GetDivision(int e, int a, int n)
		{
			if (n == 0) return Math.Pow(e, (a));
			return a * GetDivision(e, a - 1, n - 1);
		}
	}
}
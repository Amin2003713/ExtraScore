namespace _17
{
	internal class _17
	{
		static void Main(string[] args)
		{
			Console.Write("inter the number : ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter the base u want : ");
			int b = Convert.ToInt32(Console.ReadLine());
			if (b >= 10)
			{
				Console.WriteLine($"the number {a} in base {b} is {GetBase(a, b)}");
			}
			else
				Console.WriteLine("cannot do this ");
			Console.ReadKey();

		}

		private static string GetBase(int a, int b)
		{
			if (b > a) return a.ToString();
			int c = Math.DivRem(a, b).Remainder;
			return GetBase(Math.DivRem(a, b).Quotient, b) + c.ToString();
		}
	}
}
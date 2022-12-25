namespace _20
{
	internal class _20
	{
		static void Main(string[] args)
		{
			for (int n = 1; n <= 15; n++)
			{
				Console.WriteLine($"sequence number {n} is => {Seq(n)}");
			}
			Console.ReadKey();

		}




		public static int Seq(int n)
		{
			if (n == 1) return 2;

			return 2 * Seq(n - 1) - 1;
		}
	}
}

namespace _19
{
	internal class _19
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"-------------------------------------------------------------------------------------------------");
			Console.WriteLine($"|\t\ttan\t\t|\t\tsin\t\t|\t\tcos\t\t|");
			Console.WriteLine($"-------------------------------------------------------------------------------------------------");
			for (int i = 5; i < 90; i += 5)
			{
				Console.WriteLine($"|\t{Math.Tan(i)}\t|\t{Math.Sin(i)}\t|\t{Math.Cos(i)}\t|");
				Console.WriteLine($"-------------------------------------------------------------------------------------------------");
			}
			Console.ReadKey();

		}
	}
}
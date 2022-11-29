namespace _16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("inter a :");
			var a = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter b :");
			var b = Convert.ToInt32(Console.ReadLine());
			Console.Write("inter c :");
			var c = Convert.ToInt32(Console.ReadLine());
			if (IsTriangle(a, b, c))
			{
				if (IsSagh(a, b, c))
					Console.WriteLine("2");
				else if (IsAzlae(a, b, c))
					Console.WriteLine("3");
				else if (Is90De(a, b, c))
					Console.WriteLine("1");
				else
					Console.WriteLine("-1");
			}
			else
				Console.WriteLine("0");
			Console.ReadKey();

		}

		private static bool Is90De(int a, int b, int c)
		{
			var bigger = 0;
			if (a > b && a > c)
			{
				bigger = a;
				return Math.Pow(bigger, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
			}
			else if (b > a && b > c)
			{
				bigger = b;
				return Math.Pow(bigger, 2) == Math.Pow(a, 2) + Math.Pow(c, 2);
			}
			else if (c > b && c > a)
			{
				bigger = c;
				return Math.Pow(bigger, 2) == Math.Pow(b, 2) + Math.Pow(a, 2);
			}

			return false;
		}

		private static bool IsAzlae(int a, int b, int c)
		{
			return (a == b && a == c && c == b);
		}

		private static bool IsSagh(int a, int b, int c)
		{
			return (a == b || a == c || b == c);
		}

		private static bool IsTriangle(int a, int b, int c)
		{
			return (a + c > b && a + b > c && c + b > a);
		}
	}
}
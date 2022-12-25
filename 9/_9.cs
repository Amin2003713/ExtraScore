class _9
{
	public static void Main(string[] args)
	{
		Console.Write("inter a chareckter : ");
		char ch = Convert.ToChar(Console.ReadLine());
		bool digit = IsDigit(ch);
		bool Upp = IsUpperChar(ch);
		bool low = IsLowerChar(ch);
		Console.WriteLine($"is {ch} a digit ? {digit}\nis {ch} a upperchar ? {Upp}\nIs {ch} a lowerChar ? {low}");
		Console.ReadKey();

	}

	public static bool IsLowerChar(char ch)
	{
		return char.IsLower(ch);
	}

	public static bool IsUpperChar(char ch)
	{
		return char.IsUpper(ch);
	}

	public static bool IsDigit(char ch)
	{
		return char.IsDigit(ch);
	}
}

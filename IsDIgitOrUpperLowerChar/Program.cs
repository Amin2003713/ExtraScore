class Program
{
	public static void Main(string[] args)
	{
		Console.Write("inter a chareckter : ");
		var ch = Convert.ToChar(Console.ReadLine());
		var digit = IsDigit(ch);
		var Upp = IsUpperChar(ch);
		var low = IsLowerChar(ch);
		Console.WriteLine($"is {ch} a digit ? {digit}\nis {ch} a upperchar ? {Upp}\nIs {ch} a lowerChar ? {low}");
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

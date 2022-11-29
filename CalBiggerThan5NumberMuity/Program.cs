﻿class Program
{
	public static void Main(string[] args)
	{
		Console.Write("Inter a number : ");
		var num = (Console.ReadLine());
		GetResult(num);
	}

	public static void GetResult(string number)
	{
		var intList = number.Select(digit => int.Parse(digit.ToString()));
		int result = 1;
		foreach (var i in intList)
		{
			if (i > 5) result *= i;
		}
		Console.WriteLine($"the result of multiply digit that are a > 5 is => {(result)}");
	}
}

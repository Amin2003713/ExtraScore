using MD.PersianDateTime;
internal class Program
{
	private static void Main(string[] args)
	{
		//سال را به فرمت میلادی وارد کنید و تقویم ان سال میلادی را به حجری دریافت کنید 
		Console.Write("Inter the first day of the year : ");
		var date = Convert.ToDateTime(Console.ReadLine());
		var persianDate = new PersianDateTime(date);
		var targetYear = persianDate.AddYears(1);

		while (true)
		{
			if (persianDate == targetYear)
				break;
			Console.WriteLine($"year {persianDate.Year} monthe {persianDate.Month}  day {persianDate.Day} ");
			persianDate = persianDate.AddDays(1);
		}

		Console.ReadKey();
	}
}
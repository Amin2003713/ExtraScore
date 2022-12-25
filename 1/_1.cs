using MD.PersianDateTime;
internal class _1 //اینا ننویسید از رو من
{
	private static void Main(string[] args)
	{
		//سال را به فرمت میلادی وارد کنید و تقویم ان سال میلادی را به حجری دریافت کنید 
		Console.Write("Inter the first day of the year : ");
		DateTime date = Convert.ToDateTime(Console.ReadLine());
		PersianDateTime persianDate = new PersianDateTime(date);
		DateTime targetYear = persianDate.AddYears(1);

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
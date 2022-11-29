class Program
{
    public static void Main(string[] args)
    {
        Console.Write("inter your salary for taxing cal : ");
        var salary = Convert.ToInt32(Console.ReadLine());
        CalTaxing(salary);
    }

    public static void CalTaxing(int salary)
    {
        if (salary <= 483000)
        {
            Console.WriteLine($"you must pay {salary * 0 / 100} toman for Tax");
            return;
        }

        if (salary <= 600000)
        {
            Console.WriteLine($"you must pay {(salary * 0.1).ToString("C")} toman for Tax");
            return;
        }
        if (salary <= 1000000)
        {
            Console.WriteLine($"you must pay {(salary * 0.15).ToString("C")} toman for Tax");
            return;
        }
        if (salary <= 2000000)
        {
            Console.WriteLine($"you must pay {(salary * 0.2).ToString("C")} toman for Tax");
            return;
        }
        if (salary <= 99999999)
        {
            Console.WriteLine($"you must pay {(salary * 0.3).ToString("C")} toman for Tax");
            return;
        }
    }
}

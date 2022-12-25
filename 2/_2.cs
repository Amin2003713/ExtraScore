internal class _2
{
    private static void Main(string[] args)
    {
        Console.Write("inter a number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 1;
        if (IsEven(a))
        {
            while (b != a)
            {
                for (int i = 1; i <= a; i++)
                {
                    if (IsPrime(i) && IsPrime(b) && !IsEven(i) && !IsEven(b))
                    {
                        if ((b + i) % a == 0)
                        {
                            Console.WriteLine($"{i} + {b} = {a} ");
                        }
                    }

                    if (i == b) break;
                }

                b++;
            }
        }
        Console.ReadKey();

    }

    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }

    public static bool IsPrime(int a)
    {
        if (a == 0 || a == 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

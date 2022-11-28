Console.Write("inter a nimber to check if its a traianglur number or not : ");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsTrain(a));


bool IsTrain(int a)
{
    for (int i = 0; i < a; i++)
    {
        var b = ((i) * (i + 1) / 2);
        if (b == a)
        {
            return true;
        }
    }
    return false;
}
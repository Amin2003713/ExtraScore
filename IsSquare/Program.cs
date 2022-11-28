Console.Write("inter a number to check if its a qubeic or not : ");
int num = Convert.ToInt32(Console.ReadLine());
if (IsSquare(num))
    Console.WriteLine($"the number {num} is a Qubic Number ");
else
    Console.WriteLine($"{num} is not a Qubic number sorry");

bool IsSquare(int a)
{
    return (Math.Pow(Math.Floor(Math.Sqrt(a)), 2) == a);
}
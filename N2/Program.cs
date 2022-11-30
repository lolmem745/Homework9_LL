Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
void SumOfElements(int m, int n)
{
    result += Math.Min(m, n);
    if (Math.Max(m, n) != Math.Min(m, n)) SumOfElements(Math.Min(m, n) + 1, Math.Max(m, n));
}
SumOfElements(m, n);
Console.Write($"{result}");
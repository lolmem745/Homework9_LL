void SumOfElements(int m, int n)
{
    Console.Write($"{m} ");
    if (Math.Max(m, n) != Math.Min(m, n)) SumOfElements(Math.Max(m, n) - 1, Math.Min(m, n));

}
Console.Write($"Введите n: ");
SumOfElements(Convert.ToInt32(Console.ReadLine()), 1);
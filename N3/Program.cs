int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 & n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Вычисление значения функции Аккермана\nВведите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


int i = AckermannFunction(m, n);
Console.WriteLine($"A({m},{n}) = {i}");

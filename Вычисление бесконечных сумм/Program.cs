Console.Write("Введите значение x:");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите количество членов ряда (n):");
int n = int.Parse(Console.ReadLine());

double s = 0;
for (int i = 1; i <= n; i++)
{
    double t = Math.Pow(x, 4 * i + 1) / Factorial(4 * i + 1);
    s += t;
}

Console.WriteLine($"Сумма ряда: {s}");


double Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}
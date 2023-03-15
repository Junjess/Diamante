int n = 0;
while (n % 2 == 0)
{
    Console.Write("Digite um número ímpar: ");
    n = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (i <= n / 2)
    {
        Console.WriteLine(new string(' ', (n / 2) - i) + new string('x', 2 * i + 1));
    }
    else
    {
        Console.WriteLine(new string(' ', i - (n / 2)) + new string('x', 2 * (n - i) - 1));
    }
}

Console.Clear();
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine()!);
int b = Math.Abs( Method1(a));
Console.WriteLine($"сумма цифр числа {a} = {b}");

int Method1(int chislo)
{
    int sum = 0;
    while (chislo != 0)
    {
        sum += chislo % 10;
        chislo /= 10;
}
return sum;
}
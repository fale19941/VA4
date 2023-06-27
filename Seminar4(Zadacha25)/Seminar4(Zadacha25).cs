Console.Clear();
Console.WriteLine("Введите 2 числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int s = Stepen(a, b);
Console.WriteLine(s);

int Stepen(int chislo, int stepe)
{
int i = 1;
int step = 1;
while (i <= stepe)
{
step = chislo;
i++;
}
return step;
}
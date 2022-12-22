Console.WriteLine("Введите число");
double num1 = double.Parse(Console.ReadLine()!);

if (num1 % 2 == 0)
Console.WriteLine ($"Четное");
else
{
    Console.WriteLine ($"Нечетное");
}
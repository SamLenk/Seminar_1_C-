﻿// 1 задача
Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
                Console.WriteLine($"Максимальное {num1}");
            else 
                Console.WriteLine($"Максимальное {num2}");

// 2 задача
Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2 && num1 > num3)
                    Console.WriteLine("Максимальное = " + num1); 
                else if (num2 > num3)
                    Console.WriteLine("Максимальное = " + num2); 
                else
                    Console.WriteLine("Максимальное = " + num3); 

// 3 задача
int n = 1;
bool no = true;

Console.WriteLine ("Введите число");
int N = int.Parse (Console.ReadLine()!);

 Console.WriteLine ("Чётные числа от 1 до " + N);
 while (n < N)
{ 
    if (n % 2 == 0)
{
    Console.Write (n + ",");
    no = false;
}
n++;
}
if (no)
{
    Console.WriteLine ("Нет четных чисел");
}

// 4 задача
int n = 1;
bool no = true;

Console.WriteLine ("Введите число");
int N = int.Parse (Console.ReadLine()!);

 Console.WriteLine ("Чётные числа от 1 до " + N);
 while (n < N)
{ 
    if (n % 2 == 0)
{
    Console.Write (n + ",");
    no = false;
}
n++;
}
if (no)
{
    Console.WriteLine ("Нет четных чисел");
}

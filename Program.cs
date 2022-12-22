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

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

string Counter(int end, int start)
{
    if (start > end)
    {
        return start + " " + Counter(start - 1, end);
    }
    if (end == start)
    {
        return end.ToString();
    }
    return end + " " + Counter(end - 1, start);
}
Console.Clear();
Console.Write("Введите первое число:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(Counter(m, n));
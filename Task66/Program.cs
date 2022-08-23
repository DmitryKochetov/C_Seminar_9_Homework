/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.Write("Задайте M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.Write($"M = {m}; N = {n} - > {NaturalNumberSum(m, n, 0)}");


int NaturalNumberSum(int from, int to, int sum)
{
    
    sum = sum + from;
    from++;
    if (from > to) return sum;
    return NaturalNumberSum(from, to, sum);
}

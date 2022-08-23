/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
 */


Console.Clear();

Console.Write("Задайте M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}; N = {n} - > A(m,n) = {AF(m, n)}");

int AF(int m, int n) 
{
    if (m == 0) return n + 1;
    if (n == 0) return AF(m - 1, 1);
    return AF(m - 1, AF(m, n - 1));
}
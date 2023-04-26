/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int ReadNumber(string letter)
{
    Console.Write($"Enter the number {letter}: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int SumNum(int m, int n)
{
    if (n == m)
        return n;
    else
        return n + SumNum(m, n - 1);
}

int m = ReadNumber("M");
int n = ReadNumber("N");

int sum = SumNum(m, n);
System.Console.WriteLine(sum);
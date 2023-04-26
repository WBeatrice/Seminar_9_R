/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void PrintNum (int n)
{
    if (n > 0)
    {
        System.Console.Write(n + " ");
        n = n - 1;
        PrintNum(n);
    }
}

Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine());
PrintNum (n);
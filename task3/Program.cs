/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int ReadNumber(string letter)
{
    Console.Write($"Enter the positive number {letter}: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int Akkerman (int m, int n)
{
    if (m == 0)
        return n+1;
    else if (n == 0 && m > 0)
        return Akkerman (m - 1, 1);
    else 
        return (Akkerman(m - 1, Akkerman(m, n-1)));
}

int m = ReadNumber("m");
int n = ReadNumber("n");

System.Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");
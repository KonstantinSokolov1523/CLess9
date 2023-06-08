Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
 case 64:
{
task64();
break;
}
case 66:
{
task66();
break;
}
case 68:
{
task68();
break;
}
default:
{
Console.WriteLine("Некорректный ввод(такой задачи нет)");
break;
}
}



﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void task64()
{
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {N} -> {LineDown(N)}");
string LineDown(int N)
{
if(N == 1) return N.ToString();
return N + ", " + LineDown(N-1);
}
}


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void task66()
{
Console.Write("Введите начальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(LineSumm(min, max));
int LineSumm(int M, int N)
{
if(M == N) return M;
return M + LineSumm(M+1, N);
}
}


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

void task68()
{
Console.Write("Введите первое число число: ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secnum = Convert.ToInt32(Console.ReadLine());
if(firstnum > 0 && secnum >0)
{
    Console.Write($"m = {firstnum}, n = {secnum} A(m,n) = {Akker(firstnum, secnum)}");
    int Akker(int f, int s)
    {
        if (f == 0)
        {
             return s + 1;
        }
        else if (s == 0 && f > 0)
        {
            return Akker(f - 1, 1);
        }
        else
        {
            return (Akker(f - 1, Akker(f, s - 1)));
        }
    }
}
else
{
    Console.WriteLine("Введено отрицательное число(а)");
}
}
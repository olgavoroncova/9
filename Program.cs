/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


/*/Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(number);

void PrintNumbersToN(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumbersToN(n - 1);
}
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    Console.WriteLine("Число M не может быть больше N");
}
else
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}

int SumCountFromMToN(int n, int m)
{
    if (n < m) return 0;
    int sum = SumCountFromMToN(n - 1, m);
    return sum += n;
}

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Число M и N не могут быть отрицательными");
}

int SumCountFromMToN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return SumCountFromMToN(m - 1, 1);
    }
    else
    {
        return SumCountFromMToN(m - 1, SumCountFromMToN(m, n - 1));
    }
}

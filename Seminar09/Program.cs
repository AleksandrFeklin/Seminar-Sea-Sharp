// Задача 65: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 
 
// void PrintNaturalNumber(int m, int n) 
// { 
//     if (m == n) Console.Write($"{n} "); 
//     else 
//     { 
//         Console.Write($"{m} "); 
//         PrintNaturalNumber(m + 1, n); 
//     } 
// } 
 
// int m = 5; 
// int n = 8; 
// PrintNaturalNumber(m, n);



// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 
 
// void PrintNaturalNumber(int n) 
// { 
//     if (n < 1) return; 
//     if (n == 1) Console.Write($"{n} "); 
//     else 
//     { 
//         PrintNaturalNumber(n - 1); 
//         Console.Write($"{n} "); 
//     } 
// } 
// int n = 5; 
// PrintNaturalNumber(n);



// Задача 67:
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumDigits(int n)
{
    if (n / 10 != 0)
        return n % 10 + SumDigits(n / 10);
    else
        return n % 10;
}

Console.WriteLine(SumDigits(45));

// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// int PowerRec(int a, int n)
// {
//     // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // сокращенный способ записи двух следующих строк
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerRec(3, 5));
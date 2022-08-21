// bool CheckPalindrome(int number)
// {
// int digit1 = number / 10000;
// int digit5 = number % 10;

// if (digit1 != digit5)
// return false;

// int digit2 = number / 1000 % 10;
// int digit4 = number % 100 / 10;

// if (digit2 != digit4)
// return false;

// return true;
// }

// int Pow2(int number)
// {
// return number * number;
// }

// void WriteHelloWorld()
// {
// Console.WriteLine("Hello, world!");
// }

// // WriteHelloWorld();

// // Pow2(5);


// // WriteHelloWorld();

// Console.WriteLine("Введите 5-значное число для проверки");
// var numberString = Console.ReadLine();
// var number = int.Parse(numberString!);

// if (number < 10_000 && number >= 100_000)
// {
// return;
// }

// var result = CheckPalindrome(number);

// if (result == true)
// System.Console.WriteLine("Число является палиндромом");
// else
// Console.WriteLine("Не является");


//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int SumFrom1ToA(int a) {
// int result = 0;

// for (var i = 1; i <= a; i++)
// result += i;

// return result;
// }


// var number = int.Parse(Console.ReadLine()!);

// if (number <= 0)
// return;

// var result = SumFrom1ToA(number);

// Console.WriteLine(result);


// // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5


// int Digits(int num)
// {
// if (num == 0)
// return 1;

// var result = 0;

// while(num > 0)
// {
// num = num / 10;
// result++;
// }

// return result;
// }


// if (int.TryParse(Console.ReadLine()!, out var number))
// {
// if (number <= 0)
// return;

// var result = Digits(number);

// Console.WriteLine(result);

// } else {
//  Console.WriteLine("Введено не число или слишком большое число!");
// }


// второй вариант
// int Digits(int num)
// {
// if (num == 0)
// return 1;

// for (var i = 1; i < 100; i++) {
// num = num / 10;

// if (num == 0)
// return i;
// }

// return -1;
// }


// if (int.TryParse(Console.ReadLine()!, out var number))
// {
// var result = Digits(number);

// Console.WriteLine(result);

// } else {
// Console.WriteLine("Введено не число или слишком большое число!");
// }


// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// long Factorial(long num)
// {
// var result = 1L;
// for (long i = 1; i <= num; i++)
// {
// result *= i;
// }

// return result;
// }


// Console.WriteLine("Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N");

// for (; ; )
// {
// Console.WriteLine("Введите ваше число: ");
// Console.WriteLine("Для выхода введите Y");

// var inputString = Console.ReadLine()!;

// if (inputString.Equals("Y"))
// break;

// if (long.TryParse(inputString, out var number))
// {
// if (number < 0) {
// Console.WriteLine("Число должно быть неотрицательным");
// continue;
// }
// var result = Factorial(number);

// Console.WriteLine(result);

// }
// else
// {
// Console.WriteLine("Введено не число или слишком большое число!");
// }
// }


// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

long Factorial (long num)
{
    var result = 1L;  
    for(long i = 1; i <= num; i ++)
    {
        result *= i;
    }
    
    return result;
}

// Console.WriteLine("Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N");
// Console.WriteLine("Введите ваше число: ");
if (long.TryParse(Console.ReadLine()!, out var number))
{
    if (number < 0)
        return;
    var result = Factorial(number);

    Console.WriteLine(result);

} 
else {
    Console.WriteLine("Введено не число или слишком большое число!");
}

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] CreateArray()
{
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 2);

    return array;
}

var array = CreateArray();

for (int i = 0; i < 8; i++)
    Console.WriteLine(array[i]);


    
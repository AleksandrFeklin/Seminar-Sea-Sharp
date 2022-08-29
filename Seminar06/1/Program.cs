//Задача 39: Напишите программу,
// которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] ReverseArray(int[] input) {
//     int[] result = new int[input.Length];

//     for(int i = 0, j = input.Length - 1; i < input.Length; i++, j--) {
//         result[i] = input[j];
//     }

//     return result;
// }
// void PrintArray(int[] input)
// {
//     string result = "[";
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (i < input.Length - 1)
//         {
//             result += input[i] + ", ";
//         }
//         if (i == input.Length - 1)
//         {
//             result += input[i] + "]";
//         }
//     }
//     Console.WriteLine(result);
// // void PrintArray(int[] input) {
// //     for(var i = 0; i < input.Length; i++)
// //         Console.Write(input[i] + ", ");
// }

// int[] input = new int[] {1, 2, 3, 4, 5};
// var result = ReverseArray(input);
// PrintArray(result);

// void PrintArray(int[] input)
// {
//     string result = "[";
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (i < input.Length - 1)
//         {
//             result += input[i] + ", ";
//         }
//         if (i == input.Length - 1)
//         {
//             result += input[i] + "]";
//         }
//     }
//     Console.WriteLine(result);



// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// void Triangle(int A, int B, int C)
// {
//     if (((A + B) > C) && ((A + C) > B) && ((B + C) > A))
//     {
//         Console.WriteLine("Существует");
//     }
//     else
//     {
//         Console.WriteLine("Не существует");
//     }
// }

// Console.WriteLine("Введите число A ");
// string? NB1 = Console.ReadLine();
// int number1 = int.Parse(NB1);

// Console.WriteLine("Введите число B ");
// string? NB2 = Console.ReadLine();
// int number2 = int.Parse(NB2);

// Console.WriteLine("Введите число C ");
// string? NB3 = Console.ReadLine();
// int number3 = int.Parse(NB3);

// Triangle(number1, number2, number3);




// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// string DecimalToBinary(int input) {
//     var result = string.Empty;
//     var divider = 2;

//     int resultLength = 1;
//     int temp = input;

//     while(temp / divider > 0) {
//         resultLength++;
//         temp /= divider;
//     }

//     Console.WriteLine(resultLength);

//     int[] resultArray = new int[resultLength]; 

//     int index = resultLength - 1;
//     while(index > 0) {
//         resultArray[index] += input % divider;
//         index--;
//         input /= divider;
//         Console.WriteLine(resultArray[index]);
//     }
//     resultArray[0] = input;

//     for (int i = 0; i < resultArray.Length; i++)
//         result += resultArray[i];

//     return result;
// }

// Console.WriteLine("Введите 10-чное число");
// if(!int.TryParse(Console.ReadLine()!, out var number)) {
//     Console.WriteLine("Всё плохо");
// } 

// var result = DecimalToBinary(number);

// Console.WriteLine("Двоичное представление числа " + number + " есть число " + result);



// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// void Fibonacci(int n)
// {
//     int[] arr = new int[n];
//     arr[0] = 0;
//     arr[1] = 1;
//     Console.Write($"{arr[0]}, {arr[1]}, ");
//     for (int i = 2; i < n; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Fibonacci(20);

//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] ArrayCopy (int [] arr)
{
    int [] result = new int [arr.Length];
    for (int i=0; i < arr.Length; i++)
    {
        result [i] = arr [i];
    }
    return result;
}
void PrintArray(int[] input)
{
    string result = "[";
    for (int i = 0; i < input.Length; i++)
    {
        if (i < input.Length - 1)
        {
            result += input[i] + ", ";
        }
        if (i == input.Length - 1)
        {
            result += input[i] + "]";
        }
    }
    Console.WriteLine(result);
}
// void PrintArray(int[] input) {
//     for(var i = 0; i < input.Length; i++)
//         Console.Write(input[i] + ", ");
int [] a =  new int []{1,2,3,4,5};
PrintArray (a);
Console.WriteLine();
int [] b = ArrayCopy (a);
PrintArray (b);




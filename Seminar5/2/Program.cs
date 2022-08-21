// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] createArray()
// {
//     int[] array = new int[10];
//     var random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(1, 200);
//     }
//     return array;
// }
// int searchNumbers(int[] arr, int min, int max)
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= min && arr[i] <= max)
//         {
//             result += 1;
//         }
//     }
//     return result;
// }
// void viewArr(int[] arr)
// {
//     string result = "[";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//         {
//             result += arr[i] + ", ";
//         }
//         if (i == arr.Length - 1)
//         {
//             result += arr[i] + "]";
//         }
//     }
//     Console.WriteLine(result);
// }

// int[] array = createArray();
// viewArr(array);
// Console.WriteLine(searchNumbers(array, 10, 99));


















// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] createArray(int length)
{
    var random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 825);

    return array;
}
int[] multiplePair(int[] array)
{
    int newArrLength = array.Length / 2 + array.Length % 2;

    int[] result = new int[newArrLength];

    var lastResultIndex = result.Length - 1;

    for (int i = 0; i < lastResultIndex; i++)
        result[i] = array[i] * array[array.Length - i - 1];

    var middleIndex = array.Length / 2;

    if (array.Length % 2 == 0)
        result[lastResultIndex] = array[middleIndex - 1] * array[middleIndex];
    else
        result[lastResultIndex] = array[middleIndex];

    return result;
}
void printArray(int[] array) {
Console.Write("[");

for(var i = 0; i < array.Length; i++) {
Console.Write(array[i]);

if (i != array.Length - 1)
Console.Write(", ");
}

Console.Write("]");
Console.WriteLine();
}
// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
// }
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);

int[] array = createArray(length);
Console.WriteLine("Сгенерировали массив:");
printArray(array);

int[] result = multiplePair(array);
Console.WriteLine("\nПроизведение пар:");
printArray(result);




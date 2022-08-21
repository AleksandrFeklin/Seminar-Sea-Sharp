// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] createArray()
// {
// var random = new Random();
// var result = new int[12];
// for (int i = 0; i < result.Length; i++)
// {
// result[i] = random.Next(-9, 10);
// }
// return result;
// }
// void ChangePlaces(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = array[i] * -1;
// }
// }
// var array = createArray();
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + ",");
// }
// ChangePlaces(array);
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + ",");
// }





// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] createArray()
{
var random = new Random();
var result = new int[15];
for (int i = 0; i < result.Length; i++)
{
result[i] = random.Next(-9, 10);
}
return result;
}

Console.WriteLine("Введите число:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);

int[] newArray = createArray();
for (int i = 0; i < newArray.Length; i++)
{
Console.Write(newArray[i] + ",");
}
bool a = false;
Console.WriteLine();
for (int i = 0; i < newArray.Length; i++)
{
if (number == newArray[i])
{
a = true;
break;
}
}
if (a) Console.WriteLine("Да");
else Console.WriteLine("Нет");



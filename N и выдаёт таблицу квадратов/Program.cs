// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число ");
string? numberString = Console.ReadLine()!;
int x = int.Parse(numberString);
int index = 1;

if (x < 1)
{
    Console.WriteLine (" Ошибка: Число должно быть больше  0 " );
   return;
}
while (x >= index)
{

    var result = Math.Pow(index, 2);
    index++;
    Console.WriteLine(result);
}


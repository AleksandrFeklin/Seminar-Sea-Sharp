Console.WriteLine("Программа возведения числа в квадрат");
Console.WriteLine("Введите число");
string numberString = Console.ReadLine();

int number = int.Parse(numberString!);

int sgrt = number * number;

Console.WriteLine("Квадрат числа="  + sgrt);
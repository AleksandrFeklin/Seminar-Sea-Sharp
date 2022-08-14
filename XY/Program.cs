//Напишите программу, которая принимает на вход координаты точки (Х и Y).
//Причём  X не равен 0 и Y Не равен 0 и выйдет номер четверти плоскости, в которой находится эта точка.
//x > 0; y > 0 =>1
//x < 0; y > 0 => 2 
//x < 0; y < 0 => 3
//x >0 ; y < 0 => 4



Console.Clear();
Console.WriteLine("Вычисление четверти, в которой находится точка");

Console.WriteLine("Введите координату X: ");
var xString  = Console.ReadLine();
int x = int.Parse(xString!);

if (x ==  0) {

   Console.WriteLine (" Невозможно вычислить четверть для точки , лежащей на оси");
   return;
}   


Console.WriteLine("Введите координату Y: ");
var yString = Console.ReadLine();
int y = int.Parse(yString!);

if (y ==  0) {

   Console.WriteLine (" Невозможно вычислить четверть для точки , лежащей на оси");
   return;
}

int result = 0;

if (x > 0 && y > 0)
    result = 1;

else if (x < 0 && y > 0)
     result = 2;
else if (x < 0 && y < 0)
     result = 3;
else if (x > 0 && y < 0) 
     result = 4;


if (result != 0)
    Console.WriteLine("Номер четверти, в которой находится точка: " + result);

else
{
    Console.WriteLine("Ошибка. Не удалось вычислить номер четверти");
}
//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//  if (x > 0 && y > 0)
// result = 1;
// else if (x < 0 && y > 0)
// result = 2;
// else if (x < 0 && y < 0)
// result = 3;
// else if (x > 0 && y < 0)
// result = 4;

//Console.Clear();
Console.WriteLine("Введите номер четверти");

Console.WriteLine("Введите координату X: ");
string? numberstring  = Console.ReadLine();
int number = int.Parse(numberstring!);
if (number <1 || number > 4)
{

   Console.WriteLine (" Такой четверти нет");
   return;
}   


else if (number == 1)
   Console.WriteLine ("X от 0 до бесконечности и Y от 0 до бесконечности.");
else if (number == 2)
   Console.WriteLine ("X от 0 до  минус бесконечности и Y от 0 до бесконечности.");
else if (number == 3)
   Console.WriteLine ("X от 0 до минус  бесконечности и Y от минус бесконечности до 0.");
else if (number == 4)
   Console.WriteLine ("X от 0 до бесконечности и Y от минус бесконечности до 0 .");   
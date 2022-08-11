// Написать программу , которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

Random random = new Random();

int randomNumber = random.Next(10,99);

Console.WriteLine(randomNumber);

int firstDigit = randomNumber % 10; 

int secondDigit = randomNumber / 10; 
if (firstDigit > secondDigit)
    Console.WriteLine(firstDigit);
else 
    Console.WriteLine(secondDigit);
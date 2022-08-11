// Программа вывода случайного трехзначного числа и удаления второй цифры этого числа

Random random = new Random();

int randomNumber = random.Next(100, 1000);
Console.WriteLine ( "Случайное трёхзначное число = "+randomNumber);

int firstnumber = randomNumber / 100; // Получаем первую цифру

int secondnumber = randomNumber % 10; // Получаем последнюю

int thirdnumber = firstnumber * 10; // Превращем первое число в двухзначное

int result =  thirdnumber + secondnumber; // Складываем двухзначное и последнее

Console.WriteLine(result);

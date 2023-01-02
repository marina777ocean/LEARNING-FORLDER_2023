// 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98


Random random = new Random();
int number = random.Next(10,100);
Console.WriteLine(number);

int FirstNumber = number / 10;

int LastNumber = number % 10;

if (FirstNumber > LastNumber)
{
    Console.WriteLine(FirstNumber);
}
else
{
    Console.WriteLine(LastNumber);
}



// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Console.WriteLine("Введите трехзначное число: ");
//int num = int.Parse(Console.ReadLine()!);

Console.Clear();

int num = new Random().Next(100, 1000);
int num2 = num / 10 % 10;

Console.WriteLine($"Вторая цифра числа {num} является {num2}");
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. (Цифры считать справа налево)

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int num = number / 100;

if (num < 1)
{
    Console.WriteLine($"Третья цифра в заданном числе {number} отсутствует.");
}
else 
{
    num = num % 10;
    Console.WriteLine($"Третья цифра в заданном числе {number} является {num}");
}
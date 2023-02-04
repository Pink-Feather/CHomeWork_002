// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру: ");
int number = int.Parse(Console.ReadLine()!);

if (number ==6 || number == 7)
{
  Console.WriteLine($"Введеная цифра {number} означает выхдной день недели");
}
else 
if (number > 0 && number < 6)
{
    Console.WriteLine($"Введеная цифра {number} означает данный день недели не является выходным");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear ();
Console.WriteLine ("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int result = 0;
while (a != 0)
{
    result = result + a % 10;
    a = a /10;
}
Console.WriteLine($"Cумма цифр  числе: {result} ");
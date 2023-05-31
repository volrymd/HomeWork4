// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear ();
Console.WriteLine ("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int c = a;
if (b < 1)
{
    Console.WriteLine("Вы ошиблись!\nВведите второе число: ");
    b = int.Parse(Console.ReadLine()!);
}
for (int i = 2; i <= b; i++)
    a = a*c;
Console.WriteLine($"{c} в степени {b} = {a}");
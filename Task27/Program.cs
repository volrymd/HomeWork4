// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear ();
Console.WriteLine ("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

int Method (int a)
{int result = 0;
while (a != 0)
{
    result = result + a % 10;
    a = a /10;
}
return result;
}

int res = Method (b);
Console.WriteLine($"Cумма цифр в числе: {res} ");
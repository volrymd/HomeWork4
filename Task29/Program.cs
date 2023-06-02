// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
void PrintArray()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ("Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
         }
    Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
};

PrintArray();

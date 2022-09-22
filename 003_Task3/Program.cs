// **Задача 22:**
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

using static System.Console;
Clear();
Write("Введите число: ");
int Number = Convert.ToInt32(ReadLine());
int count = 1;
while(count <= Number)
{
    Write($"{Math.Pow(count,2)} ");
    count++;
}

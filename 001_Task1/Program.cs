// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

using static System.Console;
Clear();
Write("Введите координату X: ");
int x = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y: ");
int y = Convert.ToInt32(ReadLine()!);
if(x==0 || y==0) WriteLine("Error");
if(x > 0 && y > 0) 
{
    WriteLine("1");
    return;
}

if(x < 0 && y > 0) 
{
    WriteLine("2");
    return;
}

if(x < 0 && y < 0) 
{
    WriteLine("3");
    return;
}

if(x > 0 && y < 0) 
{
    WriteLine("4");
    return;
}
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру. 
//-> Среда 5 ->  Пятница

using static System.Console;
Clear();
Write("Введите номер дня недели: ");
int Number = Convert.ToInt32(ReadLine());

switch(Number)
{
    case 1:
    {
        WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        WriteLine("Вторник");
        break;
    }
    case 3:
    {
        WriteLine("Среда");
        break;
    }
    case 4:
    {
        WriteLine("Четверг");
        break;
    }
    case 5:
    {
        WriteLine("Пятница");
        break;
    }
    case 6:
    {
        WriteLine("Суббота");
        break;
    }
    case 7:
    {
        WriteLine("Воскресенье");
        break;
    }
    default: 
    {
       WriteLine("Такого дня недели не существует"); 
       break;
    }
}



// Кораблики

using static System.Console;
Clear();
Write("Введите сделанных корабликов: ");
int Number = Convert.ToInt32(ReadLine());
double Ship = Number/6;
WriteLine($"Девочка сделала {Ship*4} корабликов");
WriteLine($"Каждый мальчик сделал по {Ship} корабликов");
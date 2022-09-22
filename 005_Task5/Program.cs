

using static System.Console;
Clear();
Write("Введите выбитых банок первым стрелком: ");
int Number1 = Convert.ToInt32(ReadLine());
Write("Введите выбитых банок вторым стрелком: ");
int Number2 = Convert.ToInt32(ReadLine());
WriteLine($"Первый стрелок не выбил {Number2-1} банок");
WriteLine($"Второй стрелок не выбил {Number1-1} банок");
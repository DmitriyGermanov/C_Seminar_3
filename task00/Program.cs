// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер
//  четверти плоскости, в которой находится эта точка.


int Prompt(string message) //передать в метод текст и запросить и вернуть число от пользователя
{
    Console.Write( message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FindKvadrat(int a, int  b) //находим квадрант и выводим его
{
    if (a > 0 && b > 0) 
    Console.WriteLine("I четверть");
    if (a < 0 && b > 0) 
    Console.WriteLine("II четверть");
    if (a < 0 && b <0)
    Console.WriteLine("III четверть");
    if (a > 0 && b <0)
    Console.WriteLine("IV четверть");
}

int x = Prompt("Введите точку X:"); //запрашиваем координату Х
int y = Prompt("Введите точку Y:"); //запрашиваем координату Y
if(x!=0 && y!=0)
{
    FindKvadrat(x, y);
}
else
{
    Console.WriteLine("Точка лежит на оси");
}


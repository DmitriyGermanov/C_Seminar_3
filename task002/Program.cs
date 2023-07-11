// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).


int Coordinata(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FindQuarter(int a) // Определяем воозможные координаты и сразу выводим сообщения
{
    if (a < 1 || a > 4)
        Console.WriteLine("Неверный формат данных");
    if (a == 1)
        Console.Write("X = (0; +n), Y = (0; +n)");
    if (a == 2)
        Console.Write("X = (0; -n), Y = (0; +n)");
    if (a == 3)
        Console.Write("X = (0; -n), Y = (0; -n)");
    if (a == 4)
        Console.Write("X = (0; +n), Y = (0; -n)");
}

int quarter = Coordinata("Введите номер четверти: ");

FindQuarter(quarter);

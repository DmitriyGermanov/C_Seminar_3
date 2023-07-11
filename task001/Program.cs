// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Coordinata(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double Distance(int a, int b, int c, int d) //считаем расстояние на оси координат между двумя точками и на выходе выдаем это расстояние
{
    double distance = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
    return distance;
}

int x1 = Coordinata("Введите x координату точки 1");
int y1 = Coordinata("Введите y координату точки 1");
int x2 = Coordinata("Введите x координату точки 2");
int y2 = Coordinata("Введите y координату точки 2");


Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, x2, y2));

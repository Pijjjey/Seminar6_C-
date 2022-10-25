//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int CheckNumber(int size)
{
    int count = 0;
    for(int i = 0; i<size; i++)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine()!);
        if(num>0)
    {
        count++;
    }
    }
    return count;
}

Console.WriteLine($"{CheckNumber(7)} введённых вами чисел больше нуля.");*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

if (k1 != k2)
{
    FindPoint(k1, b1, k2, b2);
}
else
{
    Console.WriteLine("Прямые не пересекаются!");
}


void FindPoint(double k1, double b1, double k2, double b2)
{
    double x;
    x = (b2 - b1) / (k1 - k2);
    
    double y;
    y = k2 * x + b2;

    Console.WriteLine($"Точка пересечения двух прямых - ({x};{y})");
}



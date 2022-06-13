//2 задание задач без варианта
﻿static int leap(int y)
{
    if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("Введите дату по Юлианскому календарю");
Console.WriteLine("День");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Месяц");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Год");
int y = int.Parse(Console.ReadLine());
int[,] day = new int[2, 12] { { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }, { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } };
int gap = 0;
for (int i = 325; i <= y; i++)
{
    if ((i % 100 == 0) && (i % 400 != 0))
    {
        gap++;
    }
}
d += gap;
if (d > day[leap(y), m - 1])
{
    d -= day[leap(y), m - 1] - 1;
    m++;
    if (m > 12)
    {
        m = m % 12;
        y++;
    }
}
Console.WriteLine("По Григорианскому календарю: ");
Console.WriteLine("День{d}");
Console.WriteLine("Месяц{m}");
Console.WriteLine("Год{y}");

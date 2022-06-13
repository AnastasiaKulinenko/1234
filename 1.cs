//1задание задач без варианта
﻿Console.Write("Введите значение последнего промежутка n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество попыток:");
int k = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int N = rnd.Next(1, n);
while (k != 0)
{
    Console.Write("Введите число:");
    int Namb = Convert.ToInt32(Console.ReadLine());
    if (Namb == N)
    {
        Console.WriteLine("Ты угадал");
        k = 0;
    }

    {
        k--;
        Console.WriteLine("Ты не угадал");
        if (Namb <= N)
            Console.WriteLine("Загаданное число больше");
        if (Namb >= N)
            Console.WriteLine("Загаданное число меньше");
        if (k == 0)
        {
            Console.WriteLine("Игра окончена");
            ;
        }


    }
}

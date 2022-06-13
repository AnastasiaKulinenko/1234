//2 листинг своих задач
﻿int R;
Console.WriteLine("Введите величину первого сопротивления, Ом");
int r1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую велечину сопротивления, Ом");
int r2 = int.Parse(Console.ReadLine());
Console.WriteLine("Тип соединения 1 - последовательное, 2 - параллельное");
int value = int.Parse(Console.ReadLine());  
if (value == 1)
{
    R = r1 + r2;
   
}
else
{
    R = r1 * r2 / (r1 + r2);
}
Console.WriteLine(R);

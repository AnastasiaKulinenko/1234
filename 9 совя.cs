Console.WriteLine("Введите размероность массива");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} член массива: ");
    mas[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Под каким номером нужно число {1}-{n}?");
int j = int.Parse(Console.ReadLine());
Console.WriteLine(mas[j - 1]);
//3 листинг своих задач
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
Random rand = new Random();
int index = 0;
for (int i = 0; i < n; i++)
{
    mas[i] = rand.Next(0, 20);
    Console.WriteLine(mas[i]);
}
int mx = mas[0] + mas[1] + mas[2];
for (int i = 3; i < n - 2; i++)
{
    int s = mas[i] + mas[i + 1] + mas[i + 2];
    if (s > mx)
    {
        index = i;
        mx = s;
        i++;
    }
}
Console.WriteLine("Числа образующие максимальную сумму");
Console.WriteLine(mas[index]);
Console.WriteLine(mas[index + 1]);
Console.WriteLine(mas[index + 2]);

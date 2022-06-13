int num =
    int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
Console.WriteLine("Сколько было яблок?");
int yab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько было человек?");
int p = Convert.ToInt32(Console.ReadLine());
int temp = p - 1;
int[] pep = new int[p + 1];
pep[0] = yab;
for (int i = 0; i < p; i++)
{

    for (int j = 0; j < p; j++)
    {
        if (j != i)
        {
            pep[j] = pep[j] + pep[i] / temp;
        }
    }
    pep[i] = 0;
}
Console.WriteLine("У людей стало столько яблок ");
for (int i = 0; i < p; i++)
{
    Console.WriteLine(pep[i]);
}

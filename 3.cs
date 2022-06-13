Console.WriteLine("Введите площадь ");
int N = int.Parse(Console.ReadLine());
for (int q = 1; q <= 1000; q++)
{
    int a = q * q;
    for (int w = 1; w <= 1000; w++)
    {
        int b = w * w;
        for (int r = 1; r <= 1000; r++)
        {
            int c = r * r;
            int sum = a + b;
            double S = (q * w) / 2;
            if (sum == c)
            {
                if (N > S)
                {

                    Console.WriteLine($"Введите стороны треугольника a={a} b={b} c={c} ");
                    Console.WriteLine($"Площадь треугольника S={S} ");
                }

                if (N < S) ;





            }
        }
    }
}
Console.WriteLine();


using System;

class T7
{
    static void Main()
    {
        Console.Write("Сколько модулей нужно (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Размер модуля (a b): ");
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Console.Write("Размер поля (h w): ");
        input = Console.ReadLine().Split();
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);

        int maxD = FindMaxProtection(n, a, b, h, w);
        Console.WriteLine($"Максимальная толщина защиты: {maxD}");
    }

    static int FindMaxProtection(int n, int a, int b, int h, int w)
    {
        int left = 0;
        int right = Math.Min(h, w) / 2;
        int best = 0;

        while (left <= right)
        {
            int d = (left + right) / 2;

            if (CanPlace(n, a, b, h, w, d))
            {
                best = d;
                left = d + 1;
            }
            else
            {
                right = d - 1;
            }
        }

        return best;
    }

    static bool CanPlace(int n, int a, int b, int h, int w, int d)
    {
        int A = a + 2 * d;
        int B = b + 2 * d;

        // пробуем обе ориентации
        return (h / A) * (w / B) >= n || (h / B) * (w / A) >= n;
    }
}

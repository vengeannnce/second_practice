using System;
using System.Globalization;

class T1
{
    // Функция считает факториал числа
    static double MyFactorial(int k)
    {
        if (k == 0) return 1;
        double f = 1;
        for (int i = 1; i <= k; i++)
            f *= i;
        return f;
    }

    // Функция возвращает конкретный член ряда (например, для e^x)
    static double OneTerm(double val, int num)
    {
        return Math.Pow(val, num) / MyFactorial(num);
    }

    // Функция суммирует ряд до нужной точности
    static double SumSeries(double val, double tol)
    {
        double s = 0;
        int cnt = 0;
        double t = 1; // первый член

        while (Math.Abs(t) > tol)
        {
            s += t;
            cnt++;
            t = Math.Pow(val, cnt) / MyFactorial(cnt);
        }

        return s;
    }

    static void Main()
    {
        Console.Write("Введите значение x: ");
        double xVal = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Введите точность (меньше 0.01): ");
        double precision = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        if (precision >= 0.01)
        {
            Console.WriteLine("Слишком большая точность. Введите значение меньше 0.01.");
            return;
        }

        double result = SumSeries(xVal, precision);
        Console.WriteLine($"Результат вычисления функции при x={xVal} и точности {precision}: {result}");

        Console.Write("Какой член ряда Вы хотите вычислить? Введите номер n: ");
        int nTerm = int.Parse(Console.ReadLine()!);
        double nth = OneTerm(xVal, nTerm);
        Console.WriteLine($"Значение {nTerm}-го члена ряда: {nth}");
    }
}

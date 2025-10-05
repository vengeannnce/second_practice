using System;

class T3
{
    static void Main()
    {
        // Просим пользователя ввести числитель
        Console.Write("Введите числитель дроби (M): ");
        bool isNumeratorValid = int.TryParse(Console.ReadLine(), out int numeratorInput);
        if (!isNumeratorValid)
        {
            Console.WriteLine("Ошибка! Введите корректное целое число.");
            return;
        }

        // Просим пользователя ввести знаменатель
        Console.Write("Введите знаменатель дроби (N): ");
        bool isDenominatorValid = int.TryParse(Console.ReadLine(), out int denominatorInput);
        if (!isDenominatorValid || denominatorInput == 0)
        {
            Console.WriteLine("Ошибка! Знаменатель должен быть целым числом, не равным нулю.");
            return;
        }

        // Находим наибольший общий делитель (НОД) числителя и знаменателя
        int gcd = GetGCD(numeratorInput, denominatorInput);

        // Сокращаем дробь
        int finalNumerator = numeratorInput / gcd;
        int finalDenominator = denominatorInput / gcd;

        // Выводим результат
        Console.WriteLine($"Несократимая дробь: {finalNumerator}/{finalDenominator}");
    }

    // Метод для нахождения НОД двух чисел (алгоритм Евклида)
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return Math.Abs(a); // на всякий случай берем абсолютное значение
    }
}

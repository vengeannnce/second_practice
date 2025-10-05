using System;

class T4
{
    static void Main()
    {
        Console.WriteLine("Загадай число от 0 до 63");
        Console.WriteLine("Отвечай '1' если да, '0' если нет");

        int guess = 0;        // наше предполагаемое число
        int min = 0;          // нижняя граница
        int max = 63;         // верхняя граница
        int[] bits = {32,16,8,4,2,1}; // проверяем биты

        foreach (int b in bits)
        {
            Console.Write($"Твоё число >= {min + b}? (1/0): ");
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                guess += b;   // ставим бит
                min += b;     // сдвигаем нижнюю границу
            }
            else
            {
                max = min + b - 1; // корректируем верхнюю границу
            }
        }

        Console.WriteLine($"Я думаю, твое число: {guess}");
        Console.WriteLine("Угадал?");
    }
}

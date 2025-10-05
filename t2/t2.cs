using System;

class T2
{
    static void Main()
    {
        Console.Write("Введите шестизначный номер билета: ");
        string? input = Console.ReadLine();

        // Проверка на null и длину
        if (string.IsNullOrEmpty(input) || input.Length != 6)
        {
            Console.WriteLine("Ошибка! Нужно ввести шестизначное число.");
            return;
        }

        // Преобразуем в число
        bool isNumber = int.TryParse(input, out int ticket);
        if (!isNumber)
        {
            Console.WriteLine("Ошибка! Нужно ввести только цифры.");
            return;
        }

        // Разделяем число на цифры
        int d1 = ticket / 100000;
        int d2 = ticket / 10000 % 10;
        int d3 = ticket / 1000 % 10;
        int d4 = ticket / 100 % 10;
        int d5 = ticket / 10 % 10;
        int d6 = ticket % 10;

        int sumFirst = d1 + d2 + d3;
        int sumLast = d4 + d5 + d6;

        if (sumFirst == sumLast)
            Console.WriteLine("Поздравляем! У вас счастливый билет!");
        else
            Console.WriteLine("Обычный билет. Повезёт в следующий раз!");
    }
}

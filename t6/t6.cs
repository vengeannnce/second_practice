using System;

class T6
{
    static void Main()
    {
        Console.Write("Начальное число бактерий N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Количество капель антибиотика X: ");
        int X = int.Parse(Console.ReadLine());

        int bacteria = N;
        int hours = 0;
        int power = X * 10; // убивает в первый час

        Console.WriteLine("\nСостояние по часам:");

        while (bacteria > 0 && power > 0)
        {
            hours++;
            bacteria *= 2; // удвоение

            bacteria -= power; // убиваем бактерии
            if (bacteria < 0) bacteria = 0;

            power -= X; // уменьшаем эффективность

            Console.WriteLine($"Час {hours}: бактерий = {bacteria}, сила антибиотика = {power}");
        }

        Console.WriteLine($"\nПроцесс завершен за {hours} часов");
        Console.WriteLine($"Осталось бактерий: {bacteria}");
    }
}

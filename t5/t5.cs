using System;

class T5
{
    static void Main()
    {
        Console.Write("Сколько воды в аппарате (мл)? ");
        int water = int.Parse(Console.ReadLine());

        Console.Write("Сколько молока в аппарате (мл)? ");
        int milk = int.Parse(Console.ReadLine());

        int americano = 0; // сколько американо приготовили
        int latte = 0;     // сколько латте приготовили
        int money = 0;     // заработок

        while (true)
        {
            Console.WriteLine("\nВыбери напиток: 1 - Американо, 2 - Латте");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (water >= 300)
                {
                    water -= 300;
                    americano++;
                    money += 150;
                    Console.WriteLine("Американо готов!");
                }
                else
                {
                    Console.WriteLine("Воды мало!");
                    break;
                }
            }
            else if (choice == "2")
            {
                if (water >= 30 && milk >= 270)
                {
                    water -= 30;
                    milk -= 270;
                    latte++;
                    money += 170;
                    Console.WriteLine("Латте готов!");
                }
                else
                {
                    Console.WriteLine("Не хватает ингредиентов!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }

            // если ни на один напиток не хватает ресурсов
            if (water < 30 && milk < 270)
                break;
        }

        Console.WriteLine($"\nАппарат остановлен.");
        Console.WriteLine($"Остаток воды: {water} мл, молока: {milk} мл");
        Console.WriteLine($"Приготовлено: Американо {americano}, Латте {latte}");
        Console.WriteLine($"Итоговый заработок: {money} руб.");
    }
}

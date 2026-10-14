using System;

namespace Lab2;

internal class Program
{
    private static void Main()
    {
        ShowPoints();
        ShowNames();
        ShowLines();
        ShowCities();
        ShowFractions();
    }

    private static void ShowPoints()
    {
        Console.WriteLine("\nТочки");

        Point point1 = ReadPoint("Точка 1");
        Point point2 = ReadPoint("Точка 2");
        Point point3 = ReadPoint("Точка 3");

        Console.WriteLine(point1);
        Console.WriteLine(point2);
        Console.WriteLine(point3);
    }

    private static Point ReadPoint(string message)
    {
        Console.WriteLine(message);
        double x = ReadDouble("X: ");
        double y = ReadDouble("Y: ");

        return new Point(x, y);
    }

    private static void ShowNames()
    {
        Console.WriteLine("\nИмена");

        Name name1 = ReadName("Человек 1");
        Name name2 = ReadName("Человек 2");
        Name name3 = ReadName("Человек 3");

        Console.WriteLine(name1);
        Console.WriteLine(name2);
        Console.WriteLine(name3);
    }

    private static Name ReadName(string message)
    {
        Console.WriteLine(message);

        string firstName = ReadRequiredString("Имя: ");
        string surname = ReadOptionalString("Фамилия: ");
        string patronymic = ReadOptionalString("Отчество: ");

        return new Name(firstName, surname, patronymic);
    }

    private static string ReadRequiredString(string message)
    {
        while (true)
        {
            Console.Write(message);
            string value = Console.ReadLine() ?? "";

            value = value.Trim();

            if (value.Length > 0)
            {
                return value;
            }

            Console.WriteLine("Поле не должно быть пустым.");
        }
    }

    private static string ReadOptionalString(string message)
    {
        Console.Write(message);
        return (Console.ReadLine() ?? "").Trim();
    }

    private static void ShowLines()
    {
        Console.WriteLine("\nЛинии");

        Point start1 = ReadPoint("Начало линии 1");
        Point end1 = ReadPoint("Конец линии 1");
        Point start2 = ReadPoint("Начало линии 2");
        Point end2 = ReadPoint("Конец линии 2");

        Line line1 = new Line(start1, end1);
        Line line2 = new Line(start2, end2);
        Line line3 = new Line(line1.Start, line2.End);

        Console.WriteLine("\nИсходные линии:");
        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);

        Console.WriteLine("\nИзменяем общие точки.");

        line1.Start.X = ReadDouble("Новый X линии 1: ");
        line1.Start.Y = ReadDouble("Новый Y линии 1: ");
        line2.End.X = ReadDouble("Новый X линии 2: ");
        line2.End.Y = ReadDouble("Новый Y линии 2: ");

        Console.WriteLine("\nПосле изменения:");
        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);

        Console.WriteLine("\nЗаменяем начальную точку линии 1.");
        line1.Start = ReadPoint("Новая начальная точка");

        Console.WriteLine(line1);
        Console.WriteLine(line3);
    }

    private static void ShowCities()
    {
        Console.WriteLine("\nГорода");

        int count = ReadIntInRange(
            "Количество городов (1-10): ", 1, 10);

        City[] cities = new City[count];

        for (int i = 0; i < count; i++)
        {
            string name = ReadRequiredString(
                "Название города " + i + ": ");

            cities[i] = new City(name);
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nПути из " + cities[i].Name);

            int pathCount = ReadIntInRange(
                "Количество путей (0-" + (count - 1) + "): ",
                0, count - 1);

            City[] connected = new City[pathCount];
            int[] costs = new int[pathCount];

            for (int j = 0; j < pathCount; j++)
            {
                Console.WriteLine("Города назначения:");

                for (int k = 0; k < count; k++)
                {
                    Console.WriteLine(
                        k + " - " + cities[k].Name);
                }

                int index = ReadIntInRange(
                    "Индекс города: ", 0, count - 1);

                while (index == i ||
                    IsDuplicate(connected, j, cities[index]))
                {
                    Console.WriteLine(
                        "Нельзя выбрать этот город повторно.");

                    index = ReadIntInRange(
                        "Индекс города: ", 0, count - 1);
                }

                connected[j] = cities[index];

                costs[j] = ReadIntInRange(
                    "Стоимость пути: ", 0, 1000000);
            }

            cities[i].ConnectedCities = connected;
            cities[i].Costs = costs;
        }

        Console.WriteLine("\nСписок городов:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(cities[i]);
        }

        Console.WriteLine("\nВторой конструктор City.");

        string extraName = ReadRequiredString(
            "Название дополнительного города: ");

        int destination = ReadIntInRange(
            "Индекс города назначения: ", 0, count - 1);

        int cost = ReadIntInRange(
            "Стоимость пути: ", 0, 1000000);

        City extraCity = new City(
            extraName,
            new City[] { cities[destination] },
            new int[] { cost });

        Console.WriteLine(extraCity);
    }

    private static bool IsDuplicate(
        City[] cities,
        int count,
        City city)
    {
        for (int i = 0; i < count; i++)
        {
            if (cities[i] == city)
            {
                return true;
            }
        }

        return false;
    }

    private static void ShowFractions()
    {
        Console.WriteLine("\nДроби");

        Fraction f1 = ReadFraction("Первая дробь");
        Fraction f2 = ReadFraction("Вторая дробь");
        Fraction f3 = ReadFraction("Третья дробь");

        int number = ReadInt("Целое число: ");

        Console.WriteLine(
            f1 + " + " + f2 + " = " + f1.sum(f2));
        Console.WriteLine(
            f1 + " - " + f2 + " = " + f1.minus(f2));
        Console.WriteLine(
            f1 + " * " + f2 + " = " + f1.mult(f2));

        if (f2.Numerator != 0)
        {
            Console.WriteLine(
                f1 + " / " + f2 + " = " + f1.div(f2));
        }
        else
        {
            Console.WriteLine("Деление на нулевую дробь.");
        }

        Console.WriteLine(
            f1 + " + " + number + " = " + f1.sum(number));
        Console.WriteLine(
            f1 + " - " + number + " = " + f1.minus(number));
        Console.WriteLine(
            f1 + " * " + number + " = " + f1.mult(number));

        if (number != 0)
        {
            Console.WriteLine(
                f1 + " / " + number + " = " + f1.div(number));
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }

        if (f3.Numerator != 0)
        {
            Fraction result = f1.sum(f2).div(f3).minus(5);
            Console.WriteLine(
                "f1.sum(f2).div(f3).minus(5) = " + result);
        }
        else
        {
            Console.WriteLine(
                "Выражение нельзя вычислить: дробь равна нулю.");
        }
    }

    private static Fraction ReadFraction(string message)
    {
        Console.WriteLine(message);

        int numerator = ReadInt("Числитель: ");
        int denominator = ReadInt("Знаменатель: ");

        while (denominator == 0)
        {
            Console.WriteLine(
                "Знаменатель не может быть нулём.");
            denominator = ReadInt("Введите знаменатель: ");
        }

        return new Fraction(numerator, denominator);
    }

    private static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            if (double.TryParse(input, out double value) &&
                !double.IsNaN(value) &&
                !double.IsInfinity(value))
            {
                return value;
            }

            input = input.Replace(',', '.');

            if (double.TryParse(input, out value) &&
                !double.IsNaN(value) &&
                !double.IsInfinity(value))
            {
                return value;
            }

            Console.WriteLine("Введите корректное число.");
        }
    }

    private static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            Console.WriteLine("Введите целое число.");
        }
    }

    private static int ReadIntInRange(
        string message,
        int min,
        int max)
    {
        int value = ReadInt(message);

        while (value < min || value > max)
        {
            Console.WriteLine(
                "Введите число от " + min + " до " + max + ".");

            value = ReadInt(message);
        }

        return value;
    }
}

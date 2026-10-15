using System;

namespace Lab2;

internal class Program
{
    static void Main()
    {
        ShowPoints();
        ShowNames();
        ShowLines();
        ShowCities();
        ShowCityConstructor();
        ShowFractions();
    }

    static void ShowPoints()
    {
        Console.WriteLine("ЗАДАНИЕ 1.1 — ТОЧКИ");

        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        Point p3 = new Point(5, 6);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine();
    }
    static void ShowNames()
    {
        Console.WriteLine("ЗАДАНИЕ 1.3 — ИМЕНА");

        Name n1 = ReadName();
        Name n2 = ReadName();
        Name n3 = ReadName();

        Console.WriteLine("Результат:");
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine();
    }

    static Name ReadName()
    {
        string surname = ReadOptionalText("Фамилия");
        string firstName = ReadOptionalText("Имя");
        string patronymic = ReadOptionalText("Отчество");

        return new Name(surname, firstName, patronymic);
    }

    static string ReadOptionalText(string message)
    {
        string text;

        Console.Write(message + ": ");
        text = Console.ReadLine();

        while (!string.IsNullOrWhiteSpace(text)
            && !IsValidName(text))
        {
            Console.Write("Введите только буквы: ");
            text = Console.ReadLine();
        }

        if (text == null)
        {
            return "";
        }

        return text;
    }

    static bool IsValidName(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (!char.IsLetter(text[i]) && text[i] != '-')
            {
                return false;
            }
        }

        return true;
    }

    static void ShowLines()
    {
        Console.WriteLine("ЗАДАНИЕ 2.1 — ЛИНИИ");

        Point p1 = new Point(1, 3);
        Point p2 = new Point(23, 8);
        Point p3 = new Point(5, 10);
        Point p4 = new Point(25, 10);

        Line l1 = new Line(p1, p2);
        Line l2 = new Line(p3, p4);
        Line l3 = new Line(l1.Start, l2.End);

        Console.WriteLine("До изменений:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        l1.Start.X = 2;
        l1.Start.Y = 4;
        l2.End.X = 30;
        l2.End.Y = 10;

        Console.WriteLine("После изменения координат:");
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        l1.Start = new Point(100, 100);

        Console.WriteLine("После замены начала линии 1:");
        Console.WriteLine(l1);
        Console.WriteLine(l3);
        Console.WriteLine();
    }

    static void ShowCities()
    {
        Console.WriteLine("ЗАДАНИЕ 3.3 — ГОРОДА");

        City a = new City("A");
        City b = new City("B");
        City c = new City("C");
        City d = new City("D");
        City e = new City("E");
        City f = new City("F");

        a.AddPath(f, 1);
        a.AddPath(d, 6);

        b.AddPath(a, 5);
        b.AddPath(f, 1);
        b.AddPath(c, 3);

        c.AddPath(b, 3);
        c.AddPath(d, 4);

        d.AddPath(a, 6);
        d.AddPath(c, 4);
        d.AddPath(e, 2);

        e.AddPath(f, 2);
        e.AddPath(d, 2);

        f.AddPath(a, 1);
        f.AddPath(b, 1);
        f.AddPath(e, 2);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine();
    }

    // Задание 4.8. Создание городов.
    static void ShowCityConstructor()
    {
        Console.WriteLine("ЗАДАНИЕ 4.8 — СОЗДАНИЕ ГОРОДА");

        string name = ReadRequiredText("Название города");
        int count = ReadInteger("Количество путей", 0, 5);

        City[] cities = new City[count];
        int[] costs = new int[count];

        for (int i = 0; i < count; i++)
        {
            string destination =
                ReadRequiredText("Город назначения");

            cities[i] = new City(destination);

            costs[i] = ReadInteger(
                "Стоимость пути", 1, 1000000);
        }

        City city = new City(name, cities, costs);

        Console.WriteLine("Созданный город:");
        Console.WriteLine(city);
        Console.WriteLine();
    }

    static void ShowFractions()
    {
        Console.WriteLine("ЗАДАНИЕ 5.5 — ДРОБИ");

        Fraction f1 = ReadFraction("f1");
        Fraction f2 = ReadFraction("f2");
        Fraction f3 = ReadFraction("f3");

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
            Console.WriteLine("Деление на нулевую дробь нельзя.");
        }

        int number = ReadInteger(
            "Целое число", -1000000, 1000000);

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
            Console.WriteLine("f3 не должна быть нулевой.");
        }

        Console.WriteLine();
    }

    static Fraction ReadFraction(string message)
    {
        Console.WriteLine("Введите дробь " + message);

        int numerator = ReadInteger(
            "Числитель", -1000000, 1000000);

        int denominator = ReadInteger(
            "Знаменатель", -1000000, 1000000);

        while (denominator == 0)
        {
            Console.WriteLine("Знаменатель не может быть нулём.");

            denominator = ReadInteger(
                "Знаменатель", -1000000, 1000000);
        }

        return new Fraction(numerator, denominator);
    }

    static string ReadRequiredText(string message)
    {
        string text;

        Console.Write(message + ": ");
        text = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(text))
        {
            Console.Write("Поле не должно быть пустым: ");
            text = Console.ReadLine();
        }

        return text;
    }

    static int ReadInteger(string message, int min, int max)
    {
        int number;

        Console.Write(message + ": ");

        while (!int.TryParse(Console.ReadLine(), out number)
            || number < min || number > max)
        {
            Console.Write(
                "Введите число от " + min + " до " + max + ": ");
        }

        return number;
    }
}

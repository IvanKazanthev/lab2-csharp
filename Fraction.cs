// Задание 5.5. Дроби.
// Создать класс дроби с числителем и знаменателем.
// Реализовать сложение, вычитание, умножение
// и деление дробей и целых чисел без изменения
// исходных дробей.

namespace Lab2;

internal class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get
        {
            return _numerator;
        }
        set
        {
            _numerator = value;
        }
    }

    public int Denominator
    {
        get
        {
            return _denominator;
        }
        set
        {
            _denominator = value;
        }
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Fraction sum(Fraction other)
    {
        int numerator =
            _numerator * other.Denominator
            + other.Numerator * _denominator;

        int denominator =
            _denominator * other.Denominator;

        return new Fraction(numerator, denominator);
    }

    public Fraction minus(Fraction other)
    {
        int numerator =
            _numerator * other.Denominator
            - other.Numerator * _denominator;

        int denominator =
            _denominator * other.Denominator;

        return new Fraction(numerator, denominator);
    }

    public Fraction mult(Fraction other)
    {
        int numerator = _numerator * other.Numerator;
        int denominator = _denominator * other.Denominator;

        return new Fraction(numerator, denominator);
    }

    public Fraction div(Fraction other)
    {
        int numerator = _numerator * other.Denominator;
        int denominator = _denominator * other.Numerator;

        return new Fraction(numerator, denominator);
    }

    public Fraction sum(int number)
    {
        int numerator = _numerator + number * _denominator;

        return new Fraction(numerator, _denominator);
    }

    public Fraction minus(int number)
    {
        int numerator = _numerator - number * _denominator;

        return new Fraction(numerator, _denominator);
    }

    public Fraction mult(int number)
    {
        int numerator = _numerator * number;

        return new Fraction(numerator, _denominator);
    }

    public Fraction div(int number)
    {
        int denominator = _denominator * number;

        return new Fraction(_numerator, denominator);
    }

    public override string ToString()
    {
        return _numerator + "/" + _denominator;
    }
}


using System;

namespace Lab2;

internal class Fraction
{
    private int numerator;
    private int denominator;

    public int Numerator
    {
        get
        {
            return numerator;
        }
        set
        {
            numerator = value;
            Simplify();
        }
    }

    public int Denominator
    {
        get
        {
            return denominator;
        }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException(
                    "Знаменатель не может быть равен нулю.");
            }

            denominator = value;
            Simplify();
        }
    }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException(
                "Знаменатель не может быть равен нулю.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    public Fraction sum(Fraction other)
    {
        return new Fraction(
            numerator * other.denominator
                + other.numerator * denominator,
            denominator * other.denominator);
    }

    public Fraction sum(int number)
    {
        return sum(new Fraction(number, 1));
    }

    public Fraction minus(Fraction other)
    {
        return new Fraction(
            numerator * other.denominator
                - other.numerator * denominator,
            denominator * other.denominator);
    }

    public Fraction minus(int number)
    {
        return minus(new Fraction(number, 1));
    }

    public Fraction mult(Fraction other)
    {
        return new Fraction(
            numerator * other.numerator,
            denominator * other.denominator);
    }

    public Fraction mult(int number)
    {
        return mult(new Fraction(number, 1));
    }

    public Fraction div(Fraction other)
    {
        if (other.numerator == 0)
        {
            throw new DivideByZeroException(
                "Нельзя делить на нулевую дробь.");
        }

        return new Fraction(
            numerator * other.denominator,
            denominator * other.numerator);
    }

    public Fraction div(int number)
    {
        if (number == 0)
        {
            throw new DivideByZeroException(
                "Нельзя делить на ноль.");
        }

        return div(new Fraction(number, 1));
    }

    private void Simplify()
    {
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

        int a = Math.Abs(numerator);
        int b = denominator;

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        if (a > 1)
        {
            numerator /= a;
            denominator /= a;
        }
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}

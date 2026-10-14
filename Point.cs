
namespace Lab2;

internal class Point
{
    private double x;
    private double y;

    public double X
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }

    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"{{{X};{Y}}}";
    }
}

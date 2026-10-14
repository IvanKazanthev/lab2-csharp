
using System;
using System.Text;

namespace Lab2;

internal class City
{
    private string name;
    private City[] connectedCities;
    private int[] costs;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value
                ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public City[] ConnectedCities
    {
        get
        {
            return connectedCities;
        }
    }

    public int[] Costs
    {
        get
        {
            return costs;
        }
    }

    public City(string name)
    {
        this.name = name
            ?? throw new ArgumentNullException(nameof(name));

        connectedCities = new City[0];
        costs = new int[0];
    }

    public City(string name, City[] connectedCities, int[] costs)
    {
        this.name = name
            ?? throw new ArgumentNullException(nameof(name));

        this.connectedCities = new City[0];
        this.costs = new int[0];

        SetPaths(connectedCities, costs);
    }

    public void SetPaths(City[] cities, int[] pathCosts)
    {
        if (cities == null || pathCosts == null)
        {
            throw new ArgumentNullException(
                "Города и стоимости не должны быть null.");
        }

        if (cities.Length != pathCosts.Length)
        {
            throw new ArgumentException(
                "Число городов и стоимостей должно совпадать.");
        }

        connectedCities = (City[])cities.Clone();
        costs = (int[])pathCosts.Clone();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(name);
        result.Append(": ");

        if (connectedCities.Length == 0)
        {
            result.Append("нет связанных городов");
            return result.ToString();
        }

        for (int i = 0; i < connectedCities.Length; i++)
        {
            if (i > 0)
            {
                result.Append(", ");
            }

            result.Append(connectedCities[i].Name);
            result.Append(":");
            result.Append(costs[i]);
        }

        return result.ToString();
    }
}

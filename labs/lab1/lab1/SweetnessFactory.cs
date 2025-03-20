using lab1.Sweetness.Chocolate;
using lab1.Sweetness.Chocolate.FillingChocolate;
using lab1.Sweetness.Marmalad;
using lab1.Sweetness.Sweet.Candy;
using lab1.Sweetness.Sweet.ChocolateCandy;

namespace lab1;

public abstract class SweetnessFactory
{
    public abstract Sweetness.Sweetness Create(params Object[] arr);
}

public class MarmaladeCreate : SweetnessFactory
{
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Marmalade((int)arr[0], (int)arr[1], (int)arr[2], (string)arr[3]);
    }
}

public class CandyCreate : SweetnessFactory
{
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Candy((int)arr[0], (int)arr[1], (string)arr[2], (string)arr[3], (string)arr[4]);
    }
}

public class ChocolateCandyCreate : SweetnessFactory
{
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new ChocolateCandy((int)arr[0], (int)arr[1], (string)arr[2], (string)arr[3], (bool)arr[4]);
    }
}

public class ChocolateCreate : SweetnessFactory
{
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Chocolate((int)arr[0], (int)arr[1], (string)arr[2], (bool)arr[3], (bool)arr[4]);
    }
}

public class FillingChocolateCreate : SweetnessFactory
{
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new FillingChocolate(
            (int)arr[0],
            (int)arr[1],
            (string)arr[2],
            (bool)arr[3],
            (bool)arr[4],
            (string)arr[5]
            );
    }
}
      
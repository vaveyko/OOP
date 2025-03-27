using lab1.Sweetness.Chocolate;
using lab1.Sweetness.Chocolate.FillingChocolate;
using lab1.Sweetness.Marmalad;
using lab1.Sweetness.Sweet.Candy;
using lab1.Sweetness.Sweet.ChocolateCandy;

namespace lab1;

public abstract class SweetnessFactory
{
    public abstract Type sweetnessType { get; }
    public abstract Sweetness.Sweetness Create(params Object[] arr);
}

public class MarmaladeCreate : SweetnessFactory
{
    public override Type sweetnessType => typeof(Marmalade);
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Marmalade(
            Convert.ToInt32((string)arr[0]), 
            Convert.ToInt32((string)arr[1]), 
            Convert.ToInt32((string)arr[2]),
            (string)arr[3]
            );
    }
}

public class CandyCreate : SweetnessFactory
{
    public override Type sweetnessType => typeof(Candy);
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Candy(
            Convert.ToInt32((string)arr[0]), 
            Convert.ToInt32((string)arr[1]), 
            (string)arr[2], 
            (string)arr[3], 
            (string)arr[4]
            );
    }
}

public class ChocolateCandyCreate : SweetnessFactory
{
    public override Type sweetnessType => typeof(ChocolateCandy);
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new ChocolateCandy(
            Convert.ToInt32((string)arr[0]), 
            Convert.ToInt32((string)arr[1]), 
            (string)arr[2], 
            (string)arr[3],
            Convert.ToBoolean((string)arr[4])
            );
    }
}

public class ChocolateCreate : SweetnessFactory
{
    public override Type sweetnessType => typeof(Chocolate);
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new Chocolate(
            Convert.ToInt32((string)arr[0]),
            Convert.ToInt32((string)arr[1]),
            (string)arr[2],
            Convert.ToBoolean((string)arr[3]),
            Convert.ToBoolean((string)arr[4])
            );
    }
}

public class FillingChocolateCreate : SweetnessFactory
{
    public override Type sweetnessType => typeof(FillingChocolate);
    public override Sweetness.Sweetness Create(params Object[] arr)
    {
        return new FillingChocolate(
            Convert.ToInt32((string)arr[0]),
            Convert.ToInt32((string)arr[1]),
            (string)arr[2],
            Convert.ToBoolean((string)arr[3]),
            Convert.ToBoolean((string)arr[4]),
            (string)arr[5]
            );
    }
}
      
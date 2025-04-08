namespace lab1.Sweetness.Sweet.ChocolateCandy;

public class ChocolateCandy : Sweet
{
    
    public bool isChocolateDark { get; private set; }

    public ChocolateCandy(int weight, int sweetPercent, string companiName = "", string taste = "", bool isChocolateDark=false)
        : base(weight, sweetPercent, companiName, taste)
    {
        this.isChocolateDark = isChocolateDark;
    }

    public new void Edit(params Object[] parameters)
    {
        base.Edit(parameters);
        this.isChocolateDark = (bool)parameters[4]; ;
    }

    public override string photoType => "ChocolateCandy";
    
    public override string ToString()
    {
        return base.ToString() + $"isChocolateDark: {this.isChocolateDark}";
    }
}
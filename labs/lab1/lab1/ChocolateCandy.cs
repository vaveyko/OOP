namespace lab1;

public class ChocolateCandy : Sweet
{
    public bool isChocolateDark { get; private set; }

    public ChocolateCandy(int weigth, int sweetPercent, string companiName = "", string taste = "", bool isChocolateDark=false)
        : base(weigth, sweetPercent, companiName, taste)
    {
        this.isChocolateDark = isChocolateDark;
    }
}
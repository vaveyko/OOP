namespace lab1;

public class Marmalade : Sweetness
{
    public int SourPercent { get; private set; }

    public Marmalade(int sourPercent, int weigth, int sweetPercent, string companiName="")
        : base(weigth, sweetPercent, companiName)
    {
        this.SourPercent = sourPercent;
    }
}
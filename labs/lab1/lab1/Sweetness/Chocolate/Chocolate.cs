namespace lab1.Sweetness.Chocolate;

public class Chocolate : Sweetness
{
    protected bool isBlack;
    protected bool isBubble;

    public Chocolate(int weigth, int sweetPercent, string companiName = "", bool isBlack = false, bool isBubble = false)
        : base(weigth, sweetPercent, companiName)
    {
        this.isBlack = isBlack;
        this.isBubble = isBubble;
    }

    public override string photoType => "Chocolate";

    
    public string toString()
    {
        return base.ToString() + $"isBlack: {this.isBlack}, isBubble: {this.isBubble}";
    }
}
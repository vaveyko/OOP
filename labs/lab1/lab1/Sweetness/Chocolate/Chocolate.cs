namespace lab1.Sweetness.Chocolate;

public class Chocolate : Sweetness
{
    public bool isBlack { get; private set; }
    public bool isBubble { get; private set; }

    public Chocolate(int weigth, int sweetPercent, string companiName = "", bool isBlack = false, bool isBubble = false)
        : base(weigth, sweetPercent, companiName)
    {
        this.isBlack = isBlack;
        this.isBubble = isBubble;
    }

    public override string photoType => "Chocolate";

    
    public override string ToString()
    {
        return base.ToString() + $"isBlack: {this.isBlack}, isBubble: {this.isBubble}";
    }
}
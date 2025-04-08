namespace lab1.Sweetness.Chocolate;

public class Chocolate : Sweetness
{
    public bool IsBlack { get; private set; }
    public bool IsBubble { get; private set; }

    public Chocolate(int weight, int sweetPercent, string companiName = "", bool isBlack = false, bool isBubble = false)
        : base(weight, sweetPercent, companiName)
    {
        this.IsBlack = isBlack;
        this.IsBubble = isBubble;
    }
    public new void Edit(params Object[] parameters)
    {
        base.Edit(parameters);
        this.IsBlack = (bool)parameters[3];
        this.IsBubble = (bool)parameters[4];
    }

    public override string photoType => "Chocolate";

    
    public override string ToString()
    {
        return base.ToString() + $"isBlack: {this.IsBlack}, isBubble: {this.IsBubble}";
    }
}
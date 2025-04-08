namespace lab1.Sweetness.Sweet.Candy;

public class Candy : Sweet
{
    private string color;
    public string Color
    {
        get => color;
        private set => color = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public Candy(int weight, int sweetPercent, string companiName = "", string taste="", string color="")
        : base(weight, sweetPercent, companiName, taste)
    {
        this.Color = color;
    }
    public override void Edit(params Object[] parameters)
    {
        base.Edit(parameters);
        this.Color = (string)parameters[4]; ;
    }

    public override string photoType => "Candy";
    
    public override string ToString()
    {
        return base.ToString() + $"color: {this.Color}";
    }
}
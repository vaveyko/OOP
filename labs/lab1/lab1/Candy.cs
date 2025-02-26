namespace lab1;

public class Candy : Sweet
{
    public string Color
    {
        get => Color;
        private set => Color = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public Candy(int weigth, int sweetPercent, string companiName = "", string taste="", string color="")
        : base(weigth, sweetPercent, companiName, taste)
    {
        this.Color = color;
    }
}
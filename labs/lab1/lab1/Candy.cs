namespace lab1;

public class Candy : Sweet
{
    private string color;
    public string Color
    {
        get => color;
        private set => color = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public Candy(int weigth, int sweetPercent, string companiName = "", string taste="", string color="")
        : base(weigth, sweetPercent, companiName, taste)
    {
        this.Color = color;
    }
}
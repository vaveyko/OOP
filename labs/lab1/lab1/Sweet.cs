namespace lab1;

public abstract class Sweet : Sweetness
{
    public string Taste
    {
        get => Taste;
        protected set => Taste = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    protected Sweet(int weigth, int sweetPercent, string companiName = "", string taste="")
        : base(weigth, sweetPercent, companiName)
    {
        this.Taste = taste;
    }
}
namespace lab1;

public abstract class Sweet : Sweetness
{
    protected string taste;
    public string Taste
    {
        get => taste;
        protected set => taste = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    protected Sweet(int weigth, int sweetPercent, string companiName = "", string taste="")
        : base(weigth, sweetPercent, companiName)
    {
        this.Taste = taste;
    }
}
namespace lab1.Sweetness.Sweet;

public abstract class Sweet : Sweetness
{
    protected string taste;
    public string Taste
    {
        get => taste;
        protected set => taste = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    protected Sweet(float weight, int sweetPercent, string companiName = "", string taste="")
        : base(weight, sweetPercent, companiName)
    {
        this.Taste = taste;
    }

    public override void Edit(params object[] parameters)
    {
        base.Edit(parameters);
        this.Taste = (string)parameters[3];
    }
    public override string ToString()
    {
        return base.ToString() + $"taste: {this.taste}";
    }
}
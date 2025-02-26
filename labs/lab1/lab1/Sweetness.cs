namespace lab1;

public abstract class Sweetness
{
    protected Sweetness(int weight, int sweetPercent, string companiName)
    {
        this.Weight = weight;
        this.SweetPercent = sweetPercent;
        this.CompaniName = companiName;
    }
    public void Eat(int currWeight)
    {
        this.Weight -= currWeight;
    }
    public void Present(int currWeight)
    {
        this.Weight -= currWeight;
    }
    public void Buy(int currWeight)
    {
        this.Weight += currWeight;
    }

    public float Weight { get; protected set; }
    public int SweetPercent { get; set; }
    public string CompaniName
    {
        get => CompaniName;
        protected set => CompaniName = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }
}
namespace lab1.Sweetness;

public abstract class Sweetness
{
    private static int count = 0;
    public abstract string photoType { get; }
    protected Sweetness(float weight, int sweetPercent, string companiName)
    {
        count++;
        this.Weight = weight;
        this.SweetPercent = sweetPercent;
        this.CompaniName = companiName;
    }

    public virtual void Edit(params Object[] parameters)
    {
        this.Weight = float.Parse((string)parameters[0]);
        this.SweetPercent = int.Parse((string)parameters[1]);
        this.CompaniName = (string)parameters[2];
    }
    public void Eat(float currWeight)
    {
        this.Weight -= currWeight;
    }
    public void Present(float currWeight)
    {
        this.Weight -= currWeight;
    }
    public void Buy(float currWeight)
    {
        this.Weight += currWeight;
    }

    public float Weight { get; protected set; }
    protected int sweetPercent;

    public int SweetPercent
    {
        get
        {
            return sweetPercent;
        }
        set
        {
            sweetPercent = (value > 100 || value < 0) ? (value > 100 ? 100 : 0) : value;
        }
    }

    protected string companiName;
    public string CompaniName
    {
        get => companiName;
        protected set => companiName = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }
    
    public int Count { get => count; }

    public override string ToString()
    {
        return $"weight: {this.Weight}, sweet percent: {this.SweetPercent}, compani: {this.CompaniName}";
    }
}
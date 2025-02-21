namespace lab1;

public abstract class Sweetness
{
    public void Eat(int currWeight)
    {
        this.weight -= currWeight;
    }
    public void Present(int currWeight)
    {
        this.weight -= currWeight;
    }
    public void Buy(int currWeight)
    {
        this.weight += currWeight;
    }

    public float weight { get; private set; }
    public int sweetPercent { get; set; }
}
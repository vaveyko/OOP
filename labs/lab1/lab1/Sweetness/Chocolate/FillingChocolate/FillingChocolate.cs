namespace lab1.Sweetness.Chocolate.FillingChocolate;

public class FillingChocolate : Chocolate
{
    private string filling;
    public string Filling
    {
        get => filling;
        private set => filling = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public FillingChocolate(int weight, int sweetPercent, string companiName = "", bool isBlack = false,
        bool isBubble = false, string filling="") : base(weight, sweetPercent, companiName, isBlack, isBubble)
    {
        this.Filling = filling;
    }
    public override void Edit(params Object[] parameters)
    {
        base.Edit(parameters);
        this.Filling = (string)parameters[5];
    }
    public override string photoType => "FillingChocolate";
    
    public override string ToString()
    {
        return base.ToString() + $"filling: {this.Filling}";
    }
}
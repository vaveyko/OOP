namespace lab1;

public class FillingChocolate : Chocolate
{
    private string filling;
    public string Filling
    {
        get => filling;
        private set => filling = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public FillingChocolate(int weigth, int sweetPercent, string companiName = "", bool isBlack = false,
        bool isBubble = false, string filling="") : base(weigth, sweetPercent, companiName, isBlack, isBubble)
    {
        this.Filling = filling;
    }
}
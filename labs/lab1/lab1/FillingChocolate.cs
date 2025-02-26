namespace lab1;

public class FillingChocolate : Chocolate
{
    public string Filling
    {
        get => Filling;
        private set => Filling = string.IsNullOrWhiteSpace(value) ? "--" : value;
    }

    public FillingChocolate(int weigth, int sweetPercent, string companiName = "", bool isBlack = false,
        bool isBubble = false, string filling="") : base(weigth, sweetPercent, companiName, isBlack, isBubble)
    {
        this.Filling = filling;
    }
}
namespace lab1;

public abstract class Chocolate : Sweetness
{
    public int[] size { get; protected set; } = new int[2];
    protected bool isBlack;
    protected bool isBubble;
}
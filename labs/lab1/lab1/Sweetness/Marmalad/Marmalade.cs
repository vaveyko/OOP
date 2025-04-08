namespace lab1.Sweetness.Marmalad;

public class Marmalade : Sweetness
{
    private int sourPercent;

    public Marmalade(int weight, int sweetPercent, int sourPercent, string companiName="")
        : base(weight, sweetPercent, companiName)
    {
        this.SourPercent = sourPercent;
    }
    public override void Edit(params Object[] parameters)
    {
        base.Edit(parameters);
        this.CompaniName = (string)parameters[3]; ;
    }
    
    public int SourPercent
    {
        get
        {
            return sourPercent;
        }
        set
        {
            sourPercent = (value > 100 || value < 0) ? (value > 100 ? 100 : 0) : value;
        }
        
    }

    public override string photoType => "Marmalade";
    
    public override string ToString()
    {
        return base.ToString() + $"sourPercent: {this.SourPercent}";
    }
}
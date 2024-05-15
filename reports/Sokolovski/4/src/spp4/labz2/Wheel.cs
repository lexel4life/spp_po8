namespace labz2;

public class Wheel
{
    public Wheel(string name, double size, double wear)
    {
        Name = name;
        Size = size;
        Wear = wear;
    }

    public string Name { get; set; }
    public double Size { get; set; }
    public double Wear { get; set; }
    
    public override string ToString()
    {
        return $"Name: {Name}, Size: {Size}, Wear: {Wear}";
    }
    
    
    
}
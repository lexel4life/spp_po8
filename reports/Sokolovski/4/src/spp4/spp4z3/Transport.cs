namespace spp4z3;

public class Transport
{
    public Transport(string name, string color, int numberOfSeats)
    {
        Name = name;
        Color = color;
        NumberOfSeats = numberOfSeats;
    }

    public string Name { get; set; }
    public string Color { get; set; } 
    public int NumberOfSeats { get; set; }
}
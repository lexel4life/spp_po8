namespace spp4z3;

public class Route
{
    public Route(string name, int interval)
    {
        Name = name;
        Transports = new List<Transport>();
        Interval = interval;
    }

    public void TransportCrash(Transport newTransport)
    {
        Transports.Add(newTransport);
    }

    public void TransportCrash(int value)
    {
        Interval += value;
    }

    public string Name { get; set; }
    public List<Transport> Transports { get; set; }
    public int Interval { get; set; }
    
    
}
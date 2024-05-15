namespace labz2;

public class Car
{
    public Car(string name, int numberOfWheels, double maxSpeed)
    {
        Name = name;
        NumberOfWheels = numberOfWheels;
        MaxSpeed = maxSpeed;
        Wheels = new Wheel[numberOfWheels];
        
    }

    public string Name { get; set; }
    public int NumberOfWheels { get; set; }
    public Wheel[] Wheels { get; set; }
    public double MaxSpeed { get; set; }
    
    private int _wheelsCount = 0;
    
    public void AddWheel(Wheel wheel)
    {
        if (_wheelsCount < NumberOfWheels)
        {
            Wheels[_wheelsCount] = wheel;
            _wheelsCount++;
        }
    }
    
    public override string ToString()
    {
        string wheels = string.Join("\n", Wheels.Select(wheel => wheel.ToString()));
        return $"Name: {Name}, Number of wheels: {NumberOfWheels}, Max speed: {MaxSpeed}, Wheels:\n{wheels}";   
    }
    
}
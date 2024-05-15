using labz2;

Car car = new Car("Opel", 4, 200);
Wheel wheel = new Wheel("Front Left ", 17.5, 0.05);
Wheel wheel1 = new Wheel("Front Right ", 17.5, 0.05);
Wheel wheel2 = new Wheel("Back Left ", 17.5, 0.05);
Wheel wheel3 = new Wheel("Back Right ", 17.5, 0.05);
car.AddWheel(wheel);
car.AddWheel(wheel1);
car.AddWheel(wheel2);
car.AddWheel(wheel3);
Console.WriteLine(car);
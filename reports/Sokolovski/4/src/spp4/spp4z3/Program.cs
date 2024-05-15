using spp4z3;

Route route1 = new Route("route1", 10);
Route route2 = new Route("route2", 10);

Trolleybus trolleybus1 = new Trolleybus("trolleybus1", "red", 10);
Trolleybus trolleybus2 = new Trolleybus("trolleybus2", "green", 10);
Bus bus1 = new Bus("bus1", "blue", 10);
Bus bus2 = new Bus("bus2", "red", 10);
Bus bus3 = new Bus("bus3", "green", 10);

route1.Transports.Add(trolleybus1);
route1.Transports.Add(trolleybus2);

route2.Transports.Add(bus1);
route2.Transports.Add(bus2);

route1.TransportCrash(10);

route2.TransportCrash(bus3);
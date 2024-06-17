using System;

namespace TransportManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportManager manager = new TransportManager();

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Airplane airplane = new Airplane();

            manager.AddTransport(car);
            manager.AddTransport(bicycle);
            manager.AddTransport(airplane);

            manager.ManageTransports();
        }
    }
}

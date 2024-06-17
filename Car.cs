using System;

namespace TransportManagement
{
    public class Car : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Авто едет.");
        }

        public override void Stop()
        {
            Console.WriteLine("Авто остановилось.");
        }
    }
}

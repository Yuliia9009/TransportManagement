using System;

namespace TransportManagement
{
    public class Bicycle : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Велик едет.");
        }

        public override void Stop()
        {
            Console.WriteLine("Велик остановился.");
        }
    }
}

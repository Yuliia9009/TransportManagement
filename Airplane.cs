using System;

namespace TransportManagement
{
    public class Airplane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Самолет взлетает.");
        }

        public override void Stop()
        {
            Console.WriteLine("Самолет идет на поадку.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace TransportManagement
{
    public class TransportManager
    {
        private List<Transport> transports = new List<Transport>();

        public void AddTransport(Transport transport)
        {
            transports.Add(transport);
        }

        public void ManageTransports()
        {
            foreach (var transport in transports)
            {
                transport.Move();
            }
            foreach (var transport in transports)
            {
                transport.Stop();
            }
        }
    }
}

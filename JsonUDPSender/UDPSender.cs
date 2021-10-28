using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Lib.models;

namespace JsonUDPSender
{
    class UDPSender
    {
        public void Start()
        {
            UdpClient client = new UdpClient();
            Car newcar = new Car("777", "blue", "Tesla");
            string newcarString = JsonSerializer.Serialize(newcar);

            byte[] udBuffer = Encoding.UTF8.GetBytes(newcarString);
            client.Send(udBuffer, udBuffer.Length, new IPEndPoint(IPAddress.Broadcast, 7));
        }
    }
}

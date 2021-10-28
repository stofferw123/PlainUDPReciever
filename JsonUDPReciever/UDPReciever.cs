using Lib.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonUDPReciever
{
    class UDPReciever
    {
        public void Start()
        {
            UdpClient client = new UdpClient(7);
            byte[] data;

            while (true)
            {
                IPEndPoint remoteEP = null;

                //modtager
                data = client.Receive(ref remoteEP);
               Console.WriteLine($" modtager ip = {remoteEP.Address} og port {remoteEP.Port}");
                string str = Encoding.UTF8.GetString(data);

                Console.WriteLine("modtaget tekst = " + str);

                Car recievedCar = JsonSerializer.Deserialize<Car>(data);
                Console.WriteLine(recievedCar);
            }
        }
    }
}

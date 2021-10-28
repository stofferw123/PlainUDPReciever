using System;

namespace JsonUDPReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReciever reciever = new UDPReciever();

            reciever.Start();

            Console.ReadLine();
        }
    }
}

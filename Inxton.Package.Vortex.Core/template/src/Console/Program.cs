using Plc;
using System;

namespace PlcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry.Plc.Connector.BuildAndStart();
            var main= Entry.Plc.MAIN;
            Console.WriteLine($"{main.Hello_World.AttributeName} {main.Hello_World.Synchron}");
            Console.ReadKey();
        }
    }
}

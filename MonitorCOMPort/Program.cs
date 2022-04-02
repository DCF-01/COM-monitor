// See https://aka.ms/new-console-template for more information
using System.IO.Ports;
using System.Management;

SerialPort.GetPortNames().Select(x => { Console.WriteLine(x); return x; }).ToList();

string portName = Console.ReadLine();
SerialPort port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
ReadFromCOMPort();

void ReadFromCOMPort()
{
    Console.WriteLine("Incoming data:");
    port.DataReceived += new SerialDataReceivedEventHandler(PortDataReceived);


    port.Open();

    while (true)
    {

    }
}

void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
{
    Console.WriteLine(port.ReadExisting());
}

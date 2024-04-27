using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referencia
            ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
            Console.WriteLine("Client Window");

            Console.WriteLine("{0}", Client.SayHello(Console.ReadLine()));

            Client.Close();
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.WriteLine();
        }
    }
}

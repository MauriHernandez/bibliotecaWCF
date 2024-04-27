using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;

namespace host_
{
    internal class Program
    {
        static void Main(string[] args) { 
            //ejecución de la aplicación
            Uri baseAddress = new Uri(
                "http://localhost:8733/SayHelloService");
        ServiceHost selHost = new ServiceHost(
            typeof(biblioteca.Service1), baseAddress);

            //busqueda del servicio
        WSHttpBinding binding = new WSHttpBinding();
            selHost.AddServiceEndpoint(typeof(
                biblioteca.IService1), binding, "HelloService");

            //intercambios de metadata
        ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selHost.Description.Behaviors.Add(smb);

            //abrir una terminal
            selHost.Open();
            Console.WriteLine("The services is ready.");
            //si presionas enter, termina el servicio
            Console.WriteLine("Press <ENTER> to terminate services.");
            Console.WriteLine();
            //lectura de consola
            Console.ReadLine();

            //cerrar consola
            selHost.Close();
        }
    }
}

using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace simulador_aws_iot
{
  class Program
  {
    static void Main(string[] args)
    {

      string iotendpoint = "your-device-endpoint.amazonaws.com";

      int BrokerPort = 8883;

      string Topic = "hospital";

      var CaCert = X509Certificate.CreateFromCertFile(@".\.keys\root-CA.crt");

      var ClientCert = new X509Certificate2(@".\.keys\dotnet_devicecertificate.pfx", "your-pass");

      string ClientId = Guid.NewGuid().ToString();

      var IotClient = new MqttClient(iotendpoint, BrokerPort, true, CaCert, ClientCert, MqttSslProtocols.TLSv1_2);


      IotClient.Connect(ClientId);

      Console.WriteLine("-- Connected at Hospirtal Mqqt --");


      while (true)
      {

        var sistolica = (new Random()).Next(1, 130);

        var diastolica = (new Random()).Next(1, 130);

        var Message = JsonConvert.SerializeObject(new { sistolica, diastolica });

        IotClient.Publish(Topic, Encoding.UTF8.GetBytes(Message));

        Console.WriteLine("sending data..." + Message);

        Thread.Sleep(1000);

      }

    }
  }
}

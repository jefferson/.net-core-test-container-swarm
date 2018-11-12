using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace consumer_aws_iot
{
  class Program
  {

    static CheckHealth checkHealth = new CheckHealth();

    static void Main(string[] args)
    {
      string iotendpoint = "your-endpoint.amazonaws.com";

      int BrokerPort = 8883;

      string Topic = "hospital";

      var CaCert = X509Certificate.CreateFromCertFile(@".\.keys\root-CA.crt");

      var ClientCert = new X509Certificate2(@"..keys\dotnet_devicecertificate.pfx", "your-pass");

      string ClientID = Guid.NewGuid().ToString();

      var IotClient = new MqttClient(iotendpoint, BrokerPort, true, CaCert, ClientCert, MqttSslProtocols.TLSv1_2);

      IotClient.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

      IotClient.MqttMsgSubscribed += Client_MqttMsgSubscribed;

      IotClient.Connect(ClientID);

      Console.WriteLine("-- Connected at Hospirtal Mqqt --");

      IotClient.Subscribe(new string[] { Topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

      while (true)
      {
        //keeping the main thread alive for the event call backs
      }

    }

    private static void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
    {
      Console.WriteLine("Message subscribed");
    }

    private static void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
    {
      var Message = JsonConvert.DeserializeObject<dynamic>(System.Text.Encoding.UTF8.GetString(e.Message));

      var result = checkHealth.pressure(double.Parse(Message.sistolica.ToString()), double.Parse(Message.diastolica.ToString()));

      if (result == "Valores fora do padrão de análise" || result != "PRESSÃO ARTERIAL NORMAL")
      {
        Console.WriteLine("");
        Console.WriteLine("---------------------- Alert ---------------------:  ");
        Console.WriteLine("               {0}  ", result);
        Console.WriteLine("--------------------------------------------------:  ");
        Console.WriteLine("");
      }


      Console.WriteLine("");
      Console.WriteLine("Message Received is:  " + result);
      Console.WriteLine("");

    }

  }
}


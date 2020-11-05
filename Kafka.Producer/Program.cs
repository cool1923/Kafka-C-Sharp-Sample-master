using Confluent.Kafka;
using Kafka.Data.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Kafka.Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // banner
                Console.WriteLine("Kafka Producer Sample.");
                Console.WriteLine("Press CTRL+C to exit");

                var config = new ProducerConfig
                {
                    Acks = Acks.All,
                    // BootstrapServers = "127.0.0.1:9092",
                    BootstrapServers = "192.168.16.48:9092",
                    ClientId = Dns.GetHostName(),
                };

                var cancelled = false;
                Console.CancelKeyPress += (_, e) => {
                    e.Cancel = true; // prevent the process from terminating.
                    cancelled = true;
                };

                while (!cancelled)
                {
                    // get name
                    Console.WriteLine("\nWhat is your name?");
                    var name = Console.ReadLine();

                    // get message
                    Console.WriteLine("\nWhat is your message?");
                    var message = Console.ReadLine();

                    // set time stamp
                    var msgTimeStamp = DateTime.Now;

                    Msg msg = new Msg();
                    msg.User = name;
                    msg.Message = message;
                    msg.TimeStamp = msgTimeStamp;

                    using (var producer = new ProducerBuilder<Null, string>(config).Build())
                    {
                        // convert the Msg model to json
                        var jsonMsg = JsonConvert.SerializeObject(msg);

                        // push to Kafka
                        await producer.ProduceAsync("topic_messages1", new Message<Null, string> { Value = jsonMsg });
                    }

                    // produce message to Kafka
                    Console.WriteLine("Message published to Kafka.");
                    Console.WriteLine("\n");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

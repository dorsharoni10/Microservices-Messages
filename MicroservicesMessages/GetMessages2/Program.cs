using MassTransit;
using System;

namespace GetMessages2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                // Host get the setting of the connection
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("test");
                    h.Password("test");

                });
                
                //if you to get all message from SendMassege change the name queue that be diffrent from GetMessages 
                sbc.ReceiveEndpoint("queue_1", ep =>
                {
                    ep.Consumer<MessageConsumer2>();
                });
            });
            bus.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}


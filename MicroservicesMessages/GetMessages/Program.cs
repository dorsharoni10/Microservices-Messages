using System;
using MassTransit;

namespace GetMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("test");
                    h.Password("test");

                });

                sbc.ReceiveEndpoint("queue_1", ep =>
                {
                    ep.Consumer<MessageConsumer>();
                });
            });
            bus.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}


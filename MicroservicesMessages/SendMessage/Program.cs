using System;
using MassTransit;
using System.Threading.Tasks;
using Messages;
using System.Collections.Generic;
namespace SendMessage
{
    class Program
    {
       
        public static async Task Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("test");
                    h.Password("test");
                });
            });
            bus.Start()
            DateTime date = DateTime.Now;

            var message = new Message("Yoav", new DateTime(date.Year, date.Month, date.Day), 23, "Developer");
            FilterMessage filterMessage = new FilterMessage (message.Name, message.Date, message.Job);
            
            await bus.Publish(filterMessage);

            var message2 = new Message("Yair", new DateTime(date.Year, date.Month, date.Day), 32, "Designer");
            var filterMessage2 = new FilterMessage(message2.Name, message2.Date, message2.Job);

            await bus.Publish(filterMessage2);

            Console.WriteLine("Press any Key to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}

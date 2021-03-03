using System.Threading.Tasks;
using MassTransit;
using System;
using Messages;

namespace GetMessages
{
    public class MessageConsumer : IConsumer<FilterMessage>
    {
        public async Task Consume(ConsumeContext<FilterMessage> context)
        {
            await Console.Out.WriteLineAsync($"Recieved 1:\n Name: {context.Message.Name} Date: {context.Message.Date}, Job: {context.Message.Job}");
        }
    }
}

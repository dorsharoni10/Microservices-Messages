using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using Messages;

namespace GetMessages2
{
    public class MessageConsumer2 : IConsumer<FilterMessage>
    {
        public async Task Consume(ConsumeContext<FilterMessage> context)
        {
            await Console.Out.WriteLineAsync($"Recieved 2:\n Name: {context.Message.Name} Date: {context.Message.Date}, Job: {context.Message.Job}")
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Slacker2;
using Slacker2.Models;

namespace TestApp
{
    class Program : BotService
    {
        [Subscribe("^hi")]
        public void OnMessage(SlackMessage message)
        {
            message.Reply("Hi there");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");

            SlackBot.Configuration = new SlackBotConfiguration()
            {
                AuthToken = "xoxp-41105373671-41469381379-42639991936-7ad9c24d95"
            };

            SlackBot.Run();

            Console.Read();
        }
    }
}

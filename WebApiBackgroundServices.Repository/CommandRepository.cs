using System;
using System.Threading;
using WebApiBackgroundServices.Domain;

namespace WebApiBackgroundServices.Repository
{
    public class CommandRepository : ICommandRepository
    {
        private Message _message;

        public CommandRepository()
        {
            _message = new Message
            {
                Content = "......"
            };
        }

        public string GetMessage()
        {
            return _message.Content;
        }

        public void SetMessage(Message message)
        {
            _message = message;
        }
    }
}

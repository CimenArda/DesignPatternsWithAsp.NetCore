using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator :Decorator2
    {
        private readonly ISendMessage _sendMessage;
        Context _context =new Context();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }

        public void SendMessageByEncryptotoSubject(Message message)
        {
         
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }

            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptotoSubject(message);
        }

    }
}

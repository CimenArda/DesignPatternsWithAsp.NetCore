using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoByContentDecorator : Decorator2
    {
        private readonly ISendMessage _sendMessage;
        Context _context = new Context();

        public EncryptoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }

        public void SendMessageByEncryptotoContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 17.00'de publish yapılacak.";
            message.MessageSubject = "Publish";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }

            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptotoContent(message);
        }
    }
}

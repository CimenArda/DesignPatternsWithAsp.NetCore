using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator2 : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator2(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.MessageReceiver = "Everybody";
            message.MessageSender = "Admin";
            message.MessageContent = "Merhaba,Toplantı Mesajıdır.Bilginize..";
            message.MessageSubject = "Toplantı";

            _sendMessage.SendMessage(message);  
        }

    }
}

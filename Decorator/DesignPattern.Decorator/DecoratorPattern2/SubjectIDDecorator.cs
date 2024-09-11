using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator2
    {
        private readonly ISendMessage _sendMessage;
        Context _context = new Context();

        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }


        public void SendMessageByIDSubject(Message message)
        {
            if (message.MessageSubject =="1")
            {

                message.MessageSubject = "Toplantı";
            }
            if (message.MessageSubject == "2")
            {
                message.MessageSubject = "Scrum Toplantısı";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Haftalık Değerlendirme";

            }
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByIDSubject(message);
        }

















    }
}

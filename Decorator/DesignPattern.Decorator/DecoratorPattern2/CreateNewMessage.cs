using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.Decorator;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class CreateNewMessage : ISendMessage
    {
        Context context =new Context();
        public void SendMessage(Message message)
        {
           context.Messages.Add(message);
           context.SaveChanges();
        }
    }
}

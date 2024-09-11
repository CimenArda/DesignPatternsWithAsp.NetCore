using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class CreateNotifier : INotifier
    {
        Context context =new Context();
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}

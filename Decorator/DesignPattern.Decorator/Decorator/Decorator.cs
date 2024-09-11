using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class Decorator : INotifier
    {
        //Default bildirim olusturma sınıfı =>Decorator

        Context context =new Context();
        private readonly INotifier _notifier;


        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual public void CreateNotify(Notifier notifier)
        {
            notifier.NotifierCreator = "Admin";
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierType = "Public";
            notifier.NotifierChannel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}

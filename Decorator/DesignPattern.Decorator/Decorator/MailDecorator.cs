﻿using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class MailDecorator : Decorator
    {
       private readonly INotifier _notifier;
       Context _context = new Context();
        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {

            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierType = "Private-Team";
            _context.Notifiers.Add(notifier);
            _context.SaveChanges();

        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);

        }

    }
}

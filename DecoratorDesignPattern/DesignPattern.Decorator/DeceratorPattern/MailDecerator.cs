using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DeceratorPattern
{
    public class MailDecerator : Decorator
    {
        Context context = new Context();
        private readonly INotifier _notifier;

        public MailDecerator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;   
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Günlük Sabah Toplantısı";
            notifier.NotifierChannel = "Gmail-Outlook";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierType = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();

        }
        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }
    }
}

using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DeceratorPattern
{
    public class CreateNotifier : INotifier
    {
        Context context;
        public void CreateNotify(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}

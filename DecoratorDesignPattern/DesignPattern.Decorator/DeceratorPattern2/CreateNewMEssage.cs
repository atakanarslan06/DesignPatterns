using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DeceratorPattern2
{
    public class CreateNewMEssage : ISendMessage
    {
        Context context;
        public void SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}

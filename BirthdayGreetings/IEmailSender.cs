namespace BirthdayGreetings
{
    public interface IEmailSender
    {
        void Send(Greeting greeting);
    }
}
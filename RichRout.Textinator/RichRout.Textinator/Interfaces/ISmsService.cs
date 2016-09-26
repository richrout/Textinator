namespace RichRout.Textinator.Interfaces
{
    public interface ISmsService
    {
        void Send(string to, string message);
    }
}
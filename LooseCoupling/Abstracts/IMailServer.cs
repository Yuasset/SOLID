namespace LooseCoupling.Abstracts
{
    internal interface IMailServer
    {
        void SendMail(string receiver, string message);
    }
}

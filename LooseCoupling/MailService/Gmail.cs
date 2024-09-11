using LooseCoupling.Abstracts;

namespace LooseCoupling.MailService
{
    internal class Gmail : IMailServer
    {
        public void SendMail(string receiver, string message)
        {
            Console.WriteLine($"Gmail Hizmeti: {receiver} adlı kişiye <{message}> gönderildi.");
        }
    }
}

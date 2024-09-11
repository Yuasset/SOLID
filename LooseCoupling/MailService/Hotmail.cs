using LooseCoupling.Abstracts;

namespace LooseCoupling.MailService
{
    internal class Hotmail : IMailServer
    {
        public void SendMail(string receiver, string message)
        {
            Console.WriteLine($"Hotmail Hizmeti: {receiver} adlı kişiye <{message}> gönderildi.");
        }
    }
}

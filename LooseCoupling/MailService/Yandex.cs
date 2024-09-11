using LooseCoupling.Abstracts;

namespace LooseCoupling.MailService
{
    internal class Yandex : IMailServer
    {
        public void SendMail(string receiver, string message)
        {
            Console.WriteLine($"Yandex Hizmeti: {receiver} adlı kişiye <{message}> gönderildi.");
        }
    }
}

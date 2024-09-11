using LooseCoupling.Abstracts;

namespace LooseCoupling.Concretes
{
    internal class MailSender
    {
        public void Sender(IMailServer mailServer, string receiver, string message)
        {
            mailServer.SendMail(receiver, message);
        }
    }
}

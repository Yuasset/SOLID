using LooseCoupling.Concretes;
using LooseCoupling.MailService;

namespace LooseCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();
            mailSender.Sender(new Gmail(), "Yuşa Çağatay", "Merhaba, hayat nasıl gidiyor?");
        }
    }
}
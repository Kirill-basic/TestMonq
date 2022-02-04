using System;

namespace Mails.Services
{
    public interface IMailService
    {
        public void SendMail();
    }
    
    public class MailService : IMailService
    {
        public void SendMail()
        {
            Console.Write("Hello world!");
        }
    }
}
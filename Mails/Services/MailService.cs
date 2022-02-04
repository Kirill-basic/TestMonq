using System;
using Mails.DtoControllerModels;

namespace Mails.Services
{
    public interface IMailService
    {
        public void SendMail(MailInfoDto mailInfo);
    }

    //TODO:тут методы для отправки сообщений
    public class MailService : IMailService
    {
        public void SendMail(MailInfoDto mailInfo)
        {
            Console.Write("Hello world!");
        }
    }
}
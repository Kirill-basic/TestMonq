using System;
using System.Net.WebSockets;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.Repository;
using Mails.DtoControllerModels;
using Mails.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mails.Controllers
{
    [ApiController]
    [Route("api/mails")]
    public class MailController : ControllerBase
    {
        private readonly ILogRepository _repository;
        private readonly IMailService _mailService;

        public MailController(ILogRepository repository, IMailService mailService)
        {
            _repository = repository;
            _mailService = mailService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var logs = await _repository.GetLogs();
            return Ok(logs);
        }

        [HttpPost]
        public IActionResult Post(MailInfoDto model)
        {
            try
            {
                var log = new Log
                {
                    Body = model.Body,
                    Recipients = model.Recipients[0],
                    Subject = model.Subject,
                    DateOfCreation = DateTime.Now
                };

                _repository.PostLog(log);
                _mailService.SendMail(model);
                return Ok(log);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
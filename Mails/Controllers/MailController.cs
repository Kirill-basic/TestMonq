using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly ILogRepository _repository;

        public MailController(ILogRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            _repository.GetLogs();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
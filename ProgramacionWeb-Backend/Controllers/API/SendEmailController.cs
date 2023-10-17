using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramacionWeb_Backend.Models;
using ProgramacionWeb_Backend.Services;

namespace ProgramacionWeb_Backend.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        private readonly IEmailSenderService _emailsenderservice;
        public SendEmailController(IEmailSenderService emailSenderService)
        {
            _emailsenderservice = emailSenderService;
        }
        [HttpPost]
        [Route("SendData")]
        public IActionResult Send([FromBody]MensajeViewModel model)
        {
            var result = _emailsenderservice.SendEmailWithData(model);
            if (result)
            {
                return Ok(model);
            }
            else
            {
                return BadRequest(model);
            }
        }
    }
}

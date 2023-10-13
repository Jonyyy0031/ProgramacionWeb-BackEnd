using Microsoft.AspNetCore.Mvc;
using ProgramacionWeb_Backend.Services;

namespace ProgramacionWeb_Backend.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IEmailSenderService _emailsenderservice;
        public IActionResult Index()
        {
            _emailsenderservice.SendEmail("moises.torres@upqroo.edu.mx");
            return View();
        }
        public FormularioController(IEmailSenderService emailsenderservice)
        {
            _emailsenderservice = emailsenderservice;
        }
        //Nombre text, apellidos text, email email, fecha de nacimiento date, hora de entrada time,
        //turno select matutino, vespertino, comentarios text area, enviar a una funcion
        //llamada procesarsolicitud, esta funcion implementa el envio de correo al correo capturado
    }
}

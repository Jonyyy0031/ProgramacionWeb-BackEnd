using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ProgramacionWeb_Backend.Models;
using ProgramacionWeb_Backend.Services;

namespace ProgramacionWeb_Backend.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IEmailSenderService _emailsenderservice;
        public IActionResult Index()
        {
            
            return View();
        }
        public FormularioController(IEmailSenderService emailsenderservice)
        {
            _emailsenderservice = emailsenderservice;
        }
        public IActionResult EnviarFormulario(EmailViewModel model)
        {
            TempData["Email"] = model.Email;
            TempData["Comentario"] = model.Mensaje;
            _emailsenderservice.ProcesarSolicitud(model);

            var result = _emailsenderservice.SendEmail(model.Email);
            if (!result)
            {
                TempData["Email"] = null;
                TempData["EmailError"] = "Ocurrio un error";
            }
            return View("Index", model);

        }
        //Nombre text, apellidos text, email email, fecha de nacimiento date, hora de entrada time,
        //turno select matutino, vespertino, comentarios text area, enviar a una funcion
        //llamada procesarsolicitud, esta funcion implementa el envio de correo al correo capturado
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.Net;
using System.Net.Mail;

namespace ProgramacionWeb_Backend.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnviarEmail(string email, string comentario)
        {
            TempData["Email"] = email;
            TempData["Comentario"] = comentario;
            EnviarEmailSmtp(email);
            return View("Index","Contacto");
        }

        public bool EnviarEmailSmtp(string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("mail.shapp.mx",587);

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("moises.puc@shapp.mx", "Dhaserck_999");
            mail.From = new MailAddress("moises.puc@shapp.mx", "Administrador");
            mail.To.Add(email);
            mail.IsBodyHtml = true;
            mail.Body = $"Se ha contactado la persona con el correo {email} para solicitar informacion";
            smtp.Send(mail);
            return true;
        }
    }
}

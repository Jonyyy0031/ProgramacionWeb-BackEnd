using Microsoft.AspNetCore.Mvc;
using ProgramacionWeb_Backend.Models;

namespace ProgramacionWeb_Backend.Controllers
{
    public class ValidacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnviarFormulario(Curriculum model) 
        {
            string mensaje = "";
            if (ModelState.IsValid)
            {
                mensaje = "Datos Validos";
                TempData["msj"] = mensaje;
                return RedirectToAction("Index");
            }
            else
            {
                mensaje = "Datos incorrectos";
                TempData["msj"]  += mensaje;    
                return View("Index",model);
            }
            
        }
    }
}

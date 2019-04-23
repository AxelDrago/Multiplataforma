using Microsoft.AspNetCore.Mvc;
using PortalNoticias.Models;

namespace PortalNoticias.Controllers
{
    public class HomeController : Controller
    {
        // Index: La página principal
        public IActionResult Index()
        {
            return View();
        }

        // RegistrarNoticia: El formulario de registro de noticia
        public IActionResult RegistrarNoticia()
        {
            return View();
        }

        // RegistrarNoticia: Esta acción recibe los datos de        
        // la noticia y los procesa
        [HttpPost]
        public IActionResult RegistrarNoticia(Noticia noticia)
        {
            TempData["noti"] = noticia.Titulo;
            return RedirectToAction("ConfirmacionRegistro");
        }

        // ConfirmacionRegistro: Mensaje de confirmación
        public IActionResult ConfirmacionRegistro()
        {
            return View();
        }
    }
}
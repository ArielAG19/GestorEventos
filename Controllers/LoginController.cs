using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GestorEventos.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Verificar las credenciales del usuario 
            if (username == "testuser" && password == "TestPassword123!")
            {
                // Redirigir 
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Si las credenciales son incorrectas, volver a mostrar el formulario de inicio de sesión con un mensaje de error
                ModelState.AddModelError("", "Credenciales incorrectas. Por favor, inténtalo de nuevo.");
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            // No hay autenticación basada en cookies, así que no es necesario hacer logout
            
            return RedirectToAction("Index", "Home");
        }
    }
}

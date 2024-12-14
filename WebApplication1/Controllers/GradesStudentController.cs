using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class GradesStudentController : Controller
    {
        public IActionResult Index()
        {
            // Użyj danych z kontrolera nauczyciela
            return View(GradesController.Subjects);

        }
    }
}
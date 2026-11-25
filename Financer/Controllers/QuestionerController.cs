using Microsoft.AspNetCore.Mvc;

namespace Financer.Controllers;

public class QuestionerController : Controller
{
    [HttpGet]
    public IActionResult Questioner()
    {
        return View();
    }
}
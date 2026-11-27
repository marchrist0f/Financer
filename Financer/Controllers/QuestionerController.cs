using Microsoft.AspNetCore.Mvc;
using Financer.Data;
using Financer.Models;

namespace Financer.Controllers;

public class QuestionerController : Controller
{
    private readonly AppDbContext _context;

    public QuestionerController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Questioner()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Questioner(decimal salary,string occupation,string sector)
    {
        int? userId = HttpContext.Session.GetInt32("UserId");

        if (userId == null)
        {
            return RedirectToAction("Login", "LogIn");
        }

        var user = _context.Users.Find(userId.Value);

        if (user == null)
        {
            return RedirectToAction("Login", "LogIn");
        }

        if (!ModelState.IsValid ||salary < 0 || string.IsNullOrWhiteSpace(occupation) ||string.IsNullOrWhiteSpace(sector))
        {
            ViewBag.Error = "Please enter valid information!";
            return View();
        }

        user.Salary = salary;
        user.Occupation = occupation;
        user.Sector = sector;

        _context.SaveChanges();

        return RedirectToAction("Dashboard", "Home");
    }
}
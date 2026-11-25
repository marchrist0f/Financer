using Microsoft.AspNetCore.Mvc;
using Financer.Models;
using Financer.Data;

namespace Financer.Controllers;

public class LogInController : Controller{

     private readonly AppDbContext _context;

   public LogInController(AppDbContext context)
{
    _context = context;
}

     [HttpGet]
    public IActionResult Login()
    {
        return View("~/Views/LogIn/Login.cshtml");
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        var user=_context.Users.FirstOrDefault(
            u=>u.Username==username &&
            u.Password==password
        );

        if(user==null)
        {
            ViewBag.Error ="Invalid Username or Password!";
            return View("~/Views/LogIn/Login.cshtml");
        }

        HttpContext.Session.SetInt32("UserId",user.Id);
        HttpContext.Session.SetString("Username",user.Username);
        
        return RedirectToAction("Dashboard","Home");
    }
}
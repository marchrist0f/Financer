using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Financer.Models;

namespace Financer.Controllers;

public class HomeController : Controller
{

    
    
    public IActionResult Index()
    {
        return View();
    }
   
   public IActionResult Login()
   {
    return View("Login", "LogIn");
   }

    public IActionResult Signup()
    {
        return View("Signup","SignUp");
    }

     public IActionResult Dashboard()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Questioner()
    {
        return View();
    }
}

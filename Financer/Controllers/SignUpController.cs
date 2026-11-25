using Microsoft.AspNetCore.Mvc;
using Financer.Models;
using Financer.Data;

namespace Financer.Controllers;


public class SignUpController : Controller{

       private readonly AppDbContext _context;

     public SignUpController(AppDbContext context)
{
    _context = context;
}

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Signup(string username, string email, string password)
    {
        User user=new User
        {
            Username=username,
            Password=password,
            Email=email
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return RedirectToAction("Questioner","Questioner");
    }
}
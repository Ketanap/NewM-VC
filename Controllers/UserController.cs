using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewMVC.Models;

namespace NewMVC.Controllers;

public class UserController : Controller
{
    
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Signup()
    {
        User u=new User();
        u.UserName="Ketan";
        return View(u);
    }
    [HttpPost]
    public IActionResult Signup(User u)
    {

        return RedirectToAction("Login","User");
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH_20_02.Models;

namespace BTH_20_02.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]


  

    public IActionResult Render()
    {
        return View();
    }
    
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH_20_02.Models;

namespace BTH_20_02.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Render()
    {
        return View();
    }
}
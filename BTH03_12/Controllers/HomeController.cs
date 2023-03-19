using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH03_12.Models;
using BTH03_12.Models.Process;

namespace BTH03_12.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index(){
        return View();
    }
    [HttpPost]

    public IActionResult Index(string hesoA, string hesoB, string hesoC)
    {     
        string render = "";  
          render = gpt.GiaiPhuongTrinhBac(hesoA,hesoB,hesoC); 
          ViewBag.render = render;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

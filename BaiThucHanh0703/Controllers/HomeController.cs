using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;
using BaiThucHanh0703.Models.Process;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();

    

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
        public IActionResult Index(string FullName)
    {

        string render = gpt.LowUper2(FullName);
        ViewBag.output = render;
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

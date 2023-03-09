using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;

public class StudentController : Controller
{


    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName){
        string RenderName = "Hello " + FullName;
        ViewBag.render = RenderName;
      

        return View();
    }

    public IActionResult GiaiPhuongTrinhBac2(){
        return View();
    }
    [HttpPost]
    public IActionResult GiaiPhuongTrinhBac2(double a, double b, double c){

      double delta,x1,x2;
      string render;
      if(a == 0){
        render="Khong phai phuong tring bac 2";
      }
      delta = b*b - (4 * a* c);
  

       if(delta ==0) {
        x1=(-b)/(2*a);
        render = "Phuong trinh co 1 nghien" + x1;
      }
      else if(delta >0){
          x1 =(-b + Math.Sqrt(delta))/(2*a);
          x2 =(-b - Math.Sqrt(delta))/(2*a);
          render = "Phuong trinh co 2 nghiem: x1: "+ x1 + " và x2: "+ x2;
      }
      else{
        render = "Phuong trinh vo nghiem";
      }
   

      ViewBag.renderKq = render;
      return View();


    }

 
}

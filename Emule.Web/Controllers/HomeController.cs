using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Emule.Web.Models;

namespace Emule.Web.Controllers
{
  public class HomeController : Controller    //mvc controller
  {
    public IActionResult Index()
    {
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








    public IActionResult Test()
    {
      return Ok("Hi from Ron's Site");
    }

    public IActionResult TestCalc(int num1, int num2, int num3)
    {
      return Ok(num1 + num2 + num3);
    }
  }
}

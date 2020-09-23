using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emule.Web.Controllers
{
  [Route("api")]
  [ApiController]
  public class GeneralController : ControllerBase    // api controller
  {
    public GeneralController()
    {

    }




    [Route("test")]
    [HttpGet]
    public IActionResult Test()
    {
      return Ok("Hi from Ron's Site");
    }

    [Route("testcalc")]
    [HttpGet]
    public IActionResult TestCalc(int num1, int num2, int num3)
    {
      return Ok(num1 + num2 + num3);
    }

    [Route("testfile")]
    [HttpPost]
    public IActionResult TestFile(IFormFile file)
    {
      System.IO.File.WriteAllBytes($@"c:\temp\" + file.FileName, GetBytes(file));
      return Ok("success !");
    }


    //helper
    private static byte[] GetBytes(IFormFile file)
    {
      using (var target = new MemoryStream())
      {
        file.CopyTo(target);
        return target.ToArray();
      }
    }
  }
}

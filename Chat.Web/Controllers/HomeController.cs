using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chat.BL.Business;

namespace Chat.Web.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      return View();
    }



    public ActionResult Login(string userName, string password)
    {
      var isOK = UsersBL.Login(userName, password);
      return Content(isOK.ToString());
    }



    public ActionResult Test()
    {
      return Content("All OK !!!!");
    }
  }
}
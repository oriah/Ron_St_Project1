using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chat.BL.Business;
using Chat.BL.BusinessObjects;
using Chat.Web.Helpers;

namespace Chat.Web.Controllers
{
  public class HomeController : Controller
  {

    // GET: Home
    public ActionResult Index()
    {
      return View();
    }


    [HttpGet]
    public ActionResult Login(string userName, string password)
    {
      var isOK = UsersBL.Login(userName, password);
      return Content(isOK.ToString());
    }



    [HttpPost]
    public ActionResult Read(string userName)    //periodic check for new messages
    {
      var newMessages = GeneralHelper.TakeNewMessages(userName);
      return Json(newMessages);
    }


    [HttpPost]
    public ActionResult Send(string userName, string toUserName, string message)
    {
      GeneralHelper.Messages.Add(new ChatMessage(null, userName, null, toUserName, message));
      return Content(true.ToString());
    }

    public ActionResult Test()
    {
      return Content("All OK !!!!");
    }
  }
}
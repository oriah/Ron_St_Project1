using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chat.BL.BusinessObjects;

namespace Chat.Web.Helpers
{
  public static class GeneralHelper
  {

    /// <summary>
    /// All chat messages.
    /// </summary>
    public static List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();


    public static List<ChatMessage> TakeNewMessages(string userName)
    {
      var res = new List<ChatMessage>();

      foreach (var message in Messages)
      {
        if (message.ToUserName == userName)
        {
          res.Add(message);
        }
      }

      res.ForEach(item => Messages.Remove(item));

      return res;
    }

  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BL.BusinessObjects
{
  public class ChatMessage
  {
    public string UserId { get; set; }
    public string UserName { get; set; }

    public string ToUserId { get; set; }
    public string ToUserName { get; set; }

    public string Message { get; set; }


    public ChatMessage()
    {

    }

    public ChatMessage(string userId, string userName, string toUserId, string toUserName, string message)
    {
      UserId = userId;
      UserName = userName;
      ToUserId = toUserId;
      ToUserName = toUserName;
      Message = message;
    }
  }
}

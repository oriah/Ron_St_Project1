using System.Configuration;

namespace Chat.BL.Business
{
  public static class UsersBL
  {
    public static bool Login(string userName, string password)
    {
      DAL.Data.DAL dal = new DAL.Data.DAL(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
      string sql = "SELECT Count(*) " +
                   "FROM `users` " +
                   $@"WHERE user_name='{userName}' and password='{password}'";
      int res = (int)(long)dal.GetScalar(sql);
      if (res == 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

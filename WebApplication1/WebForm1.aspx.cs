using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void OnClick(object sender, EventArgs e)
    {
      string pathOrg = @"c:\temp\ron.txt";
      string path = pathOrg;
      for (int i = 0; i < 100; i++)
      {
        if (File.Exists(path))
        {
          path = pathOrg + (i + 1);
        }     
      }
      File.WriteAllText(path, TextBox1.Text);
    }
  }
}
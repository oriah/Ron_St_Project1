using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat.BL.Business;

namespace Chat.Winforms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      var isOK = UsersBL.Login(tbxUserName.Text, tbxPassword.Text);
      if (!isOK)
      {
        return;
      }

      //if (!(tbxUserName.Text == "ori" && tbxPassword.Text == "123123"))
      //{
      //  MessageBox.Show("Username and/or password invalid !");
      //  return;
      //}

      StartChat();
    }

השיחה נותקה

    private void StartChat()
    {
      tbxNewMessage.Enabled = true;
      btnSend.Enabled = true;
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      rbxChatBox.AppendText(tbxNewMessage.Text + "\r\n" + "\r\n");
    }
  }
}

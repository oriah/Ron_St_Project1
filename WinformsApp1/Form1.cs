using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(textBox1.Text + " " + textBox2.Text, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);

      Process.Start("calc");
      Process.Start("notepad");
    }
  }
}

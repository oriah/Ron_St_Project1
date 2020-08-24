namespace Chat.Winforms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbxUserName = new System.Windows.Forms.TextBox();
      this.tbxPassword = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.rbxChatBox = new System.Windows.Forms.RichTextBox();
      this.btnConnect = new System.Windows.Forms.Button();
      this.tbxNewMessage = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnSend = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 44);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "UserName";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 85);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 16);
      this.label2.TabIndex = 0;
      this.label2.Text = "Password";
      // 
      // tbxUserName
      // 
      this.tbxUserName.Location = new System.Drawing.Point(149, 44);
      this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
      this.tbxUserName.Name = "tbxUserName";
      this.tbxUserName.Size = new System.Drawing.Size(157, 22);
      this.tbxUserName.TabIndex = 0;
      // 
      // tbxPassword
      // 
      this.tbxPassword.Location = new System.Drawing.Point(149, 85);
      this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
      this.tbxPassword.Name = "tbxPassword";
      this.tbxPassword.Size = new System.Drawing.Size(157, 22);
      this.tbxPassword.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(19, 378);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "Chat";
      // 
      // rbxChatBox
      // 
      this.rbxChatBox.Location = new System.Drawing.Point(21, 404);
      this.rbxChatBox.Name = "rbxChatBox";
      this.rbxChatBox.ReadOnly = true;
      this.rbxChatBox.Size = new System.Drawing.Size(1017, 292);
      this.rbxChatBox.TabIndex = 2;
      this.rbxChatBox.Text = "";
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(113, 132);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 2;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // tbxNewMessage
      // 
      this.tbxNewMessage.Enabled = false;
      this.tbxNewMessage.Location = new System.Drawing.Point(21, 286);
      this.tbxNewMessage.Margin = new System.Windows.Forms.Padding(4);
      this.tbxNewMessage.Multiline = true;
      this.tbxNewMessage.Name = "tbxNewMessage";
      this.tbxNewMessage.Size = new System.Drawing.Size(922, 59);
      this.tbxNewMessage.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 260);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 16);
      this.label4.TabIndex = 0;
      this.label4.Text = "New Message";
      // 
      // btnSend
      // 
      this.btnSend.Enabled = false;
      this.btnSend.Location = new System.Drawing.Point(963, 322);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(75, 23);
      this.btnSend.TabIndex = 1;
      this.btnSend.Text = "Send";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbxPassword);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnConnect);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.tbxUserName);
      this.groupBox1.Location = new System.Drawing.Point(22, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(344, 163);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Log In";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 720);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSend);
      this.Controls.Add(this.rbxChatBox);
      this.Controls.Add(this.tbxNewMessage);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainForm";
      this.Text = "Ron Soccer Chat";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbxUserName;
    private System.Windows.Forms.TextBox tbxPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox rbxChatBox;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox tbxNewMessage;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}


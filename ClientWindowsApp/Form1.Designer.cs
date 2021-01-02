namespace ClientWindowsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_urlHost = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.message_list = new System.Windows.Forms.ListBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_url = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_urlHost
            // 
            this.txt_urlHost.Location = new System.Drawing.Point(76, 48);
            this.txt_urlHost.Name = "txt_urlHost";
            this.txt_urlHost.Size = new System.Drawing.Size(166, 23);
            this.txt_urlHost.TabIndex = 0;
            this.txt_urlHost.Text = "https://localhost:44379/messages";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(248, 48);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btConnect_Click);
            this.btn_connect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_connect_MouseClick);
            // 
            // message_list
            // 
            this.message_list.FormattingEnabled = true;
            this.message_list.ItemHeight = 15;
            this.message_list.Location = new System.Drawing.Point(76, 237);
            this.message_list.Name = "message_list";
            this.message_list.Size = new System.Drawing.Size(247, 109);
            this.message_list.TabIndex = 2;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(76, 171);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(166, 23);
            this.txt_message.TabIndex = 3;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(248, 171);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(76, 137);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(166, 23);
            this.txt_user.TabIndex = 5;
            // 
            // lb_url
            // 
            this.lb_url.AutoSize = true;
            this.lb_url.Location = new System.Drawing.Point(45, 52);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(25, 15);
            this.lb_url.TabIndex = 6;
            this.lb_url.Text = "Url:";
            this.lb_url.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(5, 140);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(66, 15);
            this.lb_userName.TabIndex = 7;
            this.lb_userName.Text = "User name:";
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Location = new System.Drawing.Point(17, 174);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(56, 15);
            this.lb_message.TabIndex = 8;
            this.lb_message.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.lb_url);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.message_list);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_urlHost);
            this.Name = "Form1";
            this.Text = "ClientApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_urlHost;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox message_list;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_url;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_message;
    }
}


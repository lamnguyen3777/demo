
namespace demo
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(220, 191);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 17);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "tên đăng nhập";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(387, 187);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(287, 22);
            this.textboxusername.TabIndex = 1;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(217, 244);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(70, 17);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "mật khẩu ";
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(387, 240);
            this.textboxmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(287, 22);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(488, 325);
            this.Btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(100, 28);
            this.Btnlogin.TabIndex = 4;
            this.Btnlogin.Text = "Đăng Nhập";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox textboxmatkhau;
        private System.Windows.Forms.Button Btnlogin;
    }
}


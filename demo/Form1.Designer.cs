
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
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(165, 155);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(290, 152);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(216, 20);
            this.TxtUserName.TabIndex = 1;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(163, 198);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(59, 13);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "PassWord ";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(290, 195);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(216, 20);
            this.TxtPassword.TabIndex = 3;
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(366, 264);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(75, 23);
            this.Btnlogin.TabIndex = 4;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button Btnlogin;
    }
}


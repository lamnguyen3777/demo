
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
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(220, 191);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(75, 17);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(387, 187);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(287, 22);
            this.TxtUserName.TabIndex = 1;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(223, 240);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(73, 17);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "PassWord";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(387, 240);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(287, 22);
            this.txtmatkhau.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtmatkhau;
    }
}


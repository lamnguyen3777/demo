using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            string user = "admin";
            string pass = "admin";
            if (user.Equals(textboxusername.Text) && pass.Equals(textboxmatkhau.Text))
            {
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
                textboxmatkhau.Clear();
                textboxusername.Clear();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 登录
{
    public partial class form_longin : Form
    {
        public form_longin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(51, 204, 204);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
            tbPassword.Text="";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userID = this.tbUser.Text.Trim();
            string pass = this.tbPassword.Text.Trim();

        }

     
    }
}

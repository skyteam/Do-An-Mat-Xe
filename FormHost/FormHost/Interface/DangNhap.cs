using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormHost.Interface
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Data.WebServiceData.LogIn(txtID.Text.Trim(), txtPass.Text.Trim()) == 0)
            {
                txtID.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
            else
            {
                this.Close();
            }
        }
    }
}

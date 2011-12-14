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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (Data.WebServiceData.TaoTaiKhoan(txtID.Text.Trim(), txtPass.Text.Trim()))
            {
                txtID.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Tạo Tài khoản thành công");
            }
            else
            {
                txtID.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Tạo Tài khoản thất bại");
            }
        }
    }
}

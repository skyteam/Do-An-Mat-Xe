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
    public partial class DanhMucChuXe : Form
    {
        public DanhMucChuXe()
        {
            InitializeComponent();
            GridView1.DataSource = Data.WebServiceData.BangChuXe;
        }
        public void UpdateInfo()
        {
            GridView1.Update();
        }

        private void GridView1_Click(object sender, EventArgs e)
        {
            string CMND = GridView1.CurrentRow.Cells[0].Value.ToString();
            GridView2.DataSource = Data.WebServiceData.TimXeTheoCMND(CMND);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Data.WebServiceData.BangChuXe;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Data.WebServiceData.TimChuXeTheoCMND(txtCMND.Text.Trim());
        }
    }
}

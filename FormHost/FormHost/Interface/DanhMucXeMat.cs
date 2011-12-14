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
    public partial class DanhMucXeMat : Form
    {
        public DanhMucXeMat()
        {
            InitializeComponent();
       

           

            GridView.DataSource = Data.WebServiceData.BangXeMat;
        }

        public void UpdateInfo()
        {
            GridView.DataSource = Data.WebServiceData.BangXeMat;
        }

        private void cbTatCa_Click(object sender, EventArgs e)
        {
            cbTatCa.Checked = true;
            cbChuaTimThay.Checked = false;
            cbDaTimThay.Checked = false;
            GridView.DataSource = Data.WebServiceData.BangXeMat;
        }

        private void cbChuaTimThay_Click(object sender, EventArgs e)
        {
            cbChuaTimThay.Checked = true;
            cbDaTimThay.Checked = false;
            cbTatCa.Checked = false;
            GridView.DataSource = Data.WebServiceData.BangXeChuaTimThay;
        }

        private void cbDaTimThay_Click(object sender, EventArgs e)
        {
            cbDaTimThay.Checked = true;
            cbChuaTimThay.Checked = false;
            cbTatCa.Checked = false;
            GridView.DataSource = Data.WebServiceData.BangXeDaTimThay;
        }

        private void btnTimTheoBienSo_Click(object sender, EventArgs e)
        {
            GridView.DataSource = Data.WebServiceData.TimXeTheoBienSo(txtBienSo.Text.Trim());
        }

        private void btnTimTheoCMND_Click(object sender, EventArgs e)
        {
            GridView.DataSource = Data.WebServiceData.TimXeTheoCMND(txtCMND.Text.Trim());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo();
            txtBienSo.Text = null;
            txtCMND.Text = null;
            cbTatCa.Checked = false;
            cbDaTimThay.Checked = false;
            cbChuaTimThay.Checked = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string BienSoXe = GridView.CurrentRow.Cells[0].Value.ToString();
            Data.WebServiceData.CheckDaTimThay(BienSoXe);
            UpdateInfo();
        }


    }
}

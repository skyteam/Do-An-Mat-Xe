using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using FormHost.Data;
using FormHost.Control;
using FormHost.Interface;

namespace FormHost
{
    public partial class FormHost : Form
    {
        public FormHost()
        {
            InitializeComponent();
            ShowNOKInfo();
            new Interface.DangNhap().ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cbBSHTTP.Checked && !cbMEX.Checked && !cbTCPNET.Checked && !cbWSHTTP.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 kiểu bind");
                return;
            }

            Control.WebServiceControl.InitHost();

            if (cbMEX.Checked || cbBSHTTP.Checked || cbWSHTTP.Checked)
            {
                if (!Control.WebServiceControl.StartHTTPService(txtBaseAddress.Text.Trim()))
                {
                    ShowNOKInfo();
                    return;
                }
            }

            if (cbMEX.Checked)
            {
                if (!Control.WebServiceControl.CreateMEXEndpoint())
                {
                    ShowNOKInfo();
                    return;
                }
                pcbMEX.Image = Image.FromFile("OK.png");
            }
            if (cbBSHTTP.Checked)
            {
                if (!Control.WebServiceControl.CreateBSHTTPEndpoint())
                {
                    ShowNOKInfo();
                    return;
                }
                pcbBS.Image = Image.FromFile("OK.png");
            }
            if (cbWSHTTP.Checked)
            {
                if (!Control.WebServiceControl.CreateWSHTTPEndpoint())
                {
                    ShowNOKInfo();
                    return;
                }
                pcbWS.Image = Image.FromFile("OK.png");
            }
            if (cbTCPNET.Checked)
            {
                if (!Control.WebServiceControl.CreateTCPNETEndpoint())
                {
                    ShowNOKInfo();
                    return;
                }
                pcbTCP.Image = Image.FromFile("OK.png");
            }
            Control.WebServiceControl.OpenHost();
            ShowOKInfo();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ShowNOKInfo();
        }
        private void ShowNOKInfo()
        {
            txtBaseAddress.Text = "";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            pcbBS.Image = Image.FromFile("NOK.png");
            pcbWS.Image = Image.FromFile("NOK.png");
            pcbTCP.Image = Image.FromFile("NOK.png");
            pcbMEX.Image = Image.FromFile("NOK.png");
            cbBSHTTP.Checked = false;
            cbMEX.Checked = false;
            cbTCPNET.Checked = false;
            cbWSHTTP.Checked = false;
        }
        private void ShowOKInfo()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }       

        private void btnDong_Click(object sender, EventArgs e)
        {
            Control.WebServiceControl.StopService();
            this.Close();
        }

        private void cbTCPNET_Click(object sender, EventArgs e)
        {
            if ((cbTCPNET.Checked) && !cbMEX.Checked && !cbBSHTTP.Checked && !cbWSHTTP.Checked)
            {
                txtBaseAddress.Enabled = false;
                txtBaseAddress.Text = "";
            }
            else
                txtBaseAddress.Enabled = true;
        }

        private void cbWSHTTP_Click(object sender, EventArgs e)
        {
            if ((cbTCPNET.Checked) && !cbMEX.Checked && !cbBSHTTP.Checked && !cbWSHTTP.Checked)
            {
                txtBaseAddress.Enabled = false;
                txtBaseAddress.Text = "";
            }
            else
                txtBaseAddress.Enabled = true;
        }

        private void cbBSHTTP_Click(object sender, EventArgs e)
        {
            if ((cbTCPNET.Checked) && !cbMEX.Checked && !cbBSHTTP.Checked && !cbWSHTTP.Checked)
            {
                txtBaseAddress.Enabled = false;
                txtBaseAddress.Text = "";
            }
            else
                txtBaseAddress.Enabled = true;
        }

        private void cbMEX_Click(object sender, EventArgs e)
        {
            if ((cbTCPNET.Checked) && !cbMEX.Checked && !cbBSHTTP.Checked && !cbWSHTTP.Checked)
            {
                txtBaseAddress.Enabled = false;
                txtBaseAddress.Text = "";
            }
            else
                txtBaseAddress.Enabled = true;
        }

        private void btnChuXe_Click(object sender, EventArgs e)
        {
            new DanhMucChuXe().ShowDialog();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            new DanhMucXeMat().ShowDialog();
        }

        private void btnTKhoan_Click(object sender, EventArgs e)
        {
            new Interface.TaoTaiKhoan().ShowDialog();
        }
    }
}

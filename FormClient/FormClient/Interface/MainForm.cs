using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowNOKInfo();
        }
        private void ShowNOKInfo()
        {
            txtBaseAddress.Text = "";
            txtBaseAddress.Enabled = true;
            rbtnTCPNET.Checked = false;
            rbtnWSHTTP.Checked = false;
            rbtnBSHTTP.Checked = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            ptbSign.Image = Image.FromFile("NOK.png");

        }
        private void ShowOKInfo()
        {
            txtBaseAddress.Enabled = false;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            ptbSign.Image = Image.FromFile("OK.png");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string BaseAddress = txtBaseAddress.Text.Trim();
            if (!rbtnBSHTTP.Checked && !rbtnTCPNET.Checked && !rbtnWSHTTP.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 kiểu bind");
                return;
            }
            if (Control.ClientControl.TestBSHTTP(BaseAddress) && rbtnBSHTTP.Checked)
            {
                ShowOKInfo();
                return;
            }
            if (Control.ClientControl.TestWSHTTP(BaseAddress) && rbtnWSHTTP.Checked)
            {
                ShowOKInfo();
                return;
            }
            if (Control.ClientControl.TestTCPNET() && rbtnTCPNET.Checked )
            {
                ShowOKInfo();
                return;
            }
            ShowNOKInfo();
            MessageBox.Show("Quá trình kết nối thất bại");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Control.ClientControl.Disconnect();
            ShowNOKInfo();
        }

        private void rbtnBSHTTP_Click(object sender, EventArgs e)
        {
            txtBaseAddress.Enabled = true;
            rbtnTCPNET.Checked = false;
            rbtnWSHTTP.Checked = false;
        }

        private void rbtnWSHTTP_Click(object sender, EventArgs e)
        {
            txtBaseAddress.Enabled = true;
            rbtnBSHTTP.Checked = false;
            rbtnTCPNET.Checked = false;
        }

        private void rbtnTCPNET_Click(object sender, EventArgs e)
        {
            txtBaseAddress.Text = "";
            txtBaseAddress.Enabled = false;
            rbtnBSHTTP.Checked = false;
            rbtnWSHTTP.Checked = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Control.ClientControl.Disconnect();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            new Interface.BaoMatXe().ShowDialog();
        }

        private void btnTKhoan_Click(object sender, EventArgs e)
        {
            new Interface.KiemTraXe().ShowDialog();
        }
    }
}

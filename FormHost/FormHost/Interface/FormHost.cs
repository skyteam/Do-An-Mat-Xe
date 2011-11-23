using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace FormHost
{
    public partial class FormHost : Form
    {
        public FormHost()
        {
            InitializeComponent();
            Control.WebServiceControl.SetObjectForm(this);
            ShowNOKInfo();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cbBSHTTP.Checked && !cbMEX.Checked && !cbTCPNET.Checked && !cbWSHTTP.Checked)
            {
                MessageBox.Show("Please chose at least one type of binding");
                return;
            }
            if (!Control.WebServiceControl.StartService(txtBaseAddress.Text.Trim()))
            {
                txtStatus.AppendText("Fail to Start Service\n\n");
                ShowNOKInfo();
                return;
            }
            if (cbMEX.Checked)
            {
                if (!Control.WebServiceControl.CreateMEXEndpoint())
                {
                    txtStatus.AppendText("Fail to create Mex Endpoint");
                    ShowNOKInfo();
                    return;
                }
                txtStatus.AppendText("MEX enpoint created\n\n");
            }
            if (cbBSHTTP.Checked)
            {
                if (!Control.WebServiceControl.CreateBSHTTPEndpoint())
                {
                    txtStatus.AppendText("Fail to create Basic HTTP Endpoint");
                    ShowNOKInfo();
                    return;
                }
                txtStatus.AppendText("Basic HTTP enpoint created\n\n");
            }
            if (cbWSHTTP.Checked)
            {
                if (!Control.WebServiceControl.CreateWSHTTPEndpoint())
                {
                    txtStatus.AppendText("Fail to create WS HTTP Endpoint");
                    ShowNOKInfo();
                    return;
                }
                txtStatus.AppendText("WS HTTP enpoint created\n\n");
            }
            if (cbTCPNET.Checked)
            {
                Control.WebServiceControl.CreateTCPNETEndpoint();
                string Address = "net.tcp://localhost:9000/TCPNET";
                txtStatus.AppendText("TCPNET enpoint created\n\nThe address is\n" + Address + "\n\n");
            }
            Control.WebServiceControl.OpenHost();
            ShowOKInfo();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ShowNOKInfo();
            txtStatus.AppendText("Service is destroyed\n\n");
        }
        private void ShowNOKInfo()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lbStatus.Text = "SERVICE IS NOT HOSTED";
            lbStatus.ForeColor = Color.Red;
        }
        private void ShowOKInfo()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lbStatus.Text = "SERVICE IS HOSTED";
            lbStatus.ForeColor = Color.Green;
            Control.WebServiceControl.UpdateObjectForm();
        }
        public void UpdateInfo()
        {
            dataGridView1.DataSource = Data.WebServiceData.BangXe;
            dataGridView2.DataSource = Data.WebServiceData.BangChuXeMat;
        }
    }
}

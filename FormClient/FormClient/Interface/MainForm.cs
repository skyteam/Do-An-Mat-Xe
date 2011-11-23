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
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string BaseAddress = txtBaseAddress.Text.Trim();
            if (!Control.ClientControl.TestAsynchronous(BaseAddress))
                txtStatus.AppendText("Asyschronous testing Failed\n");
            else
                txtStatus.AppendText("Asyschronous testing Successful\n");
            if (!Control.ClientControl.TestBSHTTP(BaseAddress))
                txtStatus.AppendText("BSHTTP Testing Failed\n");
            else
                txtStatus.AppendText("BSHTTP testing Successful\n");
            if (!Control.ClientControl.TestTCPNET())
                txtStatus.AppendText("TCPNET testing Failed\n");
            else
                txtStatus.AppendText("TCPNET testing Successful\n");
            if (!Control.ClientControl.TestWSHTTP(BaseAddress))
                txtStatus.AppendText("WSHTTP testing Failed\n");
            else
                txtStatus.AppendText("WSHTTP testing Successful\n");
            dataGridView1.DataSource = Control.ClientControl.GetBangXe();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = Control.ClientControl.MainProxy.ThemXe
            (
                "123",null,null,null,null,
                "456", new System.DateTime(2011, 1, 1), 
                null, null, null, null, new System.DateTime(2011, 1, 1)
            );
        }
    }
}

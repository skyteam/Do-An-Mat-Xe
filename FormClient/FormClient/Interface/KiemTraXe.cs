using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormClient.Interface
{
    public partial class KiemTraXe : Form
    {
        public KiemTraXe()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                List<XService.XeMat> List = Control.ClientControl.MainProxy.TimXeTheoCMND(txtCMND.Text.Trim()).ToList();
                if (List.Count == 0)
                    throw new Exception();

                DataTable Converter = new DataTable();
                Converter.Columns.Add(new DataColumn("BienSoXe", typeof(string)));
                Converter.Columns.Add(new DataColumn("SoMay", typeof(string)));
                Converter.Columns.Add(new DataColumn("SoKhung", typeof(string)));
                Converter.Columns.Add(new DataColumn("LoaiXe", typeof(string)));
                Converter.Columns.Add(new DataColumn("MauXe", typeof(string)));
                Converter.Columns.Add(new DataColumn("CMNDSoHuu", typeof(string)));
                Converter.Columns.Add(new DataColumn("NoiDangKy", typeof(string)));
                Converter.Columns.Add(new DataColumn("DaTimThay", typeof(bool)));

                for (int i = 0; i < List.Count; i++)
                {
                    DataRow NewRow = Converter.NewRow();
                    NewRow["BienSoXe"] = List[i].BienSoXe;
                    NewRow["SoMay"] = List[i].SoMay;
                    NewRow["SoKhung"] = List[i].SoKhung;
                    NewRow["LoaiXe"] = List[i].LoaiXe;
                    NewRow["MauXe"] = List[i].MauXe;
                    NewRow["CMNDSoHuu"] = List[i].CMNDSoHuu;
                    NewRow["NoiDangKy"] = List[i].NoiDangKy;
                    NewRow["DaTimThay"] = List[i].DaTimThay;
                    Converter.Rows.Add(NewRow);
                }

                GridView.DataSource = Converter;
            }
            catch
            {
                MessageBox.Show("CMND khong dung");
            }
        }
    }
}

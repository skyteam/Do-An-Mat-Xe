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
    public partial class BaoMatXe : Form
    {
        public BaoMatXe()
        {
            InitializeComponent();
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                XService.XeMat Xe = new XService.XeMat();
                Xe.BienSoXe = txtBienSo.Text.Trim();
                Xe.LoaiXe = txtLoaiXe.Text.Trim();
                Xe.MauXe = txtMauXe.Text.Trim();
                Xe.NoiDangKy = txtNoiDK.Text.Trim();
                Xe.SoKhung = txtSoKhung.Text.Trim();
                Xe.SoMay = txtSoMay.Text.Trim();

                XService.ChuXe People = new XService.ChuXe();
                People.CMNDSoHuu = txtCMND.Text.Trim();
                People.DiaChi = txtDiaChi.Text.Trim();
                People.DienThoai = txtDienThoai.Text.Trim();
                People.HoTen = txtHoTen.Text.Trim();
                People.NgaySinh = dtNgaySinh.Value;

                if (Control.ClientControl.MainProxy.ThemXe(Xe, People))
                    MessageBox.Show("Thông tin báo mất đã được lưu trữ dưới server");
                else
                    MessageBox.Show("Báo mất thất bại");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FormHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BService : IBService
    {
        public string LogIn()
        {
            return "LOG IN SUCCESSFULLY";
        }
        public string GetBangXeXML()
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();
            Data.WebServiceData.BangXe.WriteXml(sw);
            sw.Close();
            string TableXML = sw.ToString();
            return TableXML;
        }
        public bool ThemXe
        (
            string BienSoXe, string SoMay, string SoKhung, string LoaiXe,
            string MauXe, string CMNDSoHuu, DateTime NgayDangKy, string NoiDangKy,
            string HoTen, string DiaChi, string DienThoai, DateTime NgaySinh
        )
        {
            return Data.WebServiceData.ThemXe
            (
                    BienSoXe, SoMay, SoKhung, LoaiXe,
                    MauXe, CMNDSoHuu, NgayDangKy, NoiDangKy,
                    HoTen, DiaChi, DienThoai, NgaySinh
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormHost.Data
{
    class WebServiceData
    {
        static DataSetOBJ DataSet = new DataSetOBJ();
        static readonly string Path = System.Windows.Forms.Application.StartupPath + @"\Data.mdf";
        static readonly string ConnectString = string.Format(@"Data Source=.\SQLEXPRESS;AttachDbFilename={0};Integrated Security=True;User Instance=True",Path);
        public static System.Data.DataTable BangXe
        {
            get
            {
                using (DataSetOBJTableAdapters.BangXeTableAdapter Adap = new DataSetOBJTableAdapters.BangXeTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString)})
                {
                    Adap.Fill(DataSet.BangXe);
                    return DataSet.BangXe;
                }
            }
        }
        public static System.Data.DataTable BangChuXeMat
        {
            get
            {
                using (DataSetOBJTableAdapters.BangChuXeTableAdapter Adap = new DataSetOBJTableAdapters.BangChuXeTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
                {
                    Adap.Fill(DataSet.BangChuXe);
                    return DataSet.BangChuXe;
                }
            }
        }
        public static bool ThemXe
        (
            string BienSoXe, string SoMay, string SoKhung, string LoaiXe,
            string MauXe, string CMNDSoHuu, DateTime NgayDangKy, string NoiDangKy,
            string HoTen, string DiaChi, string DienThoai, DateTime NgaySinh
        )
        {
            try
            {
                using(DataSetOBJTableAdapters.QueriesTableAdapter Adap = new DataSetOBJTableAdapters.QueriesTableAdapter())
                Adap.SP_ThemXe
                (
                    BienSoXe, SoMay, SoKhung, LoaiXe,
                    MauXe, CMNDSoHuu, NgayDangKy, NoiDangKy,
                    HoTen, DiaChi, DienThoai, NgaySinh
                    
                );
                Control.WebServiceControl.UpdateObjectForm();
                return true;
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}

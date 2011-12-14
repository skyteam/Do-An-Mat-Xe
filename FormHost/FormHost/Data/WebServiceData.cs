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
        public static System.Data.DataTable BangXeMat
        {
            get
            {
                using (DataSetOBJTableAdapters.XeMatTableAdapter Adap = new DataSetOBJTableAdapters.XeMatTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString)})
                {
                    Adap.Fill(DataSet.XeMat);
                    return DataSet.XeMat;
                }
            }
        }
        public static System.Data.DataTable BangChuXe
        {
            get
            {
                using (DataSetOBJTableAdapters.ChuXeTableAdapter Adap = new DataSetOBJTableAdapters.ChuXeTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
                {
                    Adap.Fill(DataSet.ChuXe);
                    return DataSet.ChuXe;
                }
            }
        }
        public static System.Data.DataTable BangXeDaTimThay
        {
            get
            {
                using (DataSetOBJTableAdapters.SP_XemXeDaTimThayTableAdapter Adap =new DataSetOBJTableAdapters.SP_XemXeDaTimThayTableAdapter{Connection = new System.Data.SqlClient.SqlConnection(ConnectString)})
                {
                    Adap.Fill(DataSet.SP_XemXeDaTimThay);
                    return DataSet.SP_XemXeDaTimThay;
                }
            }
        }
        public static System.Data.DataTable BangXeChuaTimThay
        {
            get
            {
                using (DataSetOBJTableAdapters.SP_XemXeChuaTimThayTableAdapter Adap = new DataSetOBJTableAdapters.SP_XemXeChuaTimThayTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
                {
                    Adap.Fill(DataSet.SP_XemXeChuaTimThay);
                    return DataSet.SP_XemXeChuaTimThay;
                }
            }
        }
        public static System.Data.DataTable TimXeTheoBienSo(string BienSoXe)
        {
            using (DataSetOBJTableAdapters.SP_TimTheoBienSoTableAdapter Adap = new DataSetOBJTableAdapters.SP_TimTheoBienSoTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
            {
                Adap.Fill(DataSet.SP_TimTheoBienSo, BienSoXe);
                return DataSet.SP_TimTheoBienSo;
            }
        }
        public static System.Data.DataTable TimXeTheoCMND(string CMND)
        {
            using (DataSetOBJTableAdapters.SP_TimTheoCMNDTableAdapter Adap = new DataSetOBJTableAdapters.SP_TimTheoCMNDTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
            {
                Adap.Fill(DataSet.SP_TimTheoCMND, CMND);
                return DataSet.SP_TimTheoCMND;
            }
        }
        public static List<XeMat> TimXeTheoCMND_List(string CMND)
        {
            using (DataSetOBJTableAdapters.SP_TimTheoCMNDTableAdapter Adap = new DataSetOBJTableAdapters.SP_TimTheoCMNDTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
            {
                Adap.Fill(DataSet.SP_TimTheoCMND, CMND);
                List<XeMat> ListResult = new List<XeMat>();
                foreach (System.Data.DataRow i in DataSet.SP_TimTheoCMND)
                {
                    XeMat OBJ = new XeMat();
                    OBJ.BienSoXe = i[0].ToString();
                    OBJ.SoMay = i[1].ToString();
                    OBJ.SoKhung = i[2].ToString();
                    OBJ.LoaiXe = i[3].ToString();
                    OBJ.MauXe = i[4].ToString();
                    OBJ.CMNDSoHuu = i[5].ToString();
                    OBJ.NoiDangKy = i[6].ToString();
                    OBJ.DaTimThay = (bool)i[7];
                    ListResult.Add(OBJ);
                }
                return ListResult;
            }
        }
        public static System.Data.DataTable TimChuXeTheoCMND(string CMND)
        {
            using (DataSetOBJTableAdapters.SP_TimChuXeTheoCMNDTableAdapter Adap = new DataSetOBJTableAdapters.SP_TimChuXeTheoCMNDTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
            {
                Adap.Fill(DataSet.SP_TimChuXeTheoCMND, CMND);
                return DataSet.SP_TimChuXeTheoCMND;
            }
        }
        public static bool ThemXe(XeMat Xe, ChuXe People)
        {
            try
            {
                using(DataSetOBJTableAdapters.QueriesTableAdapter Adap = new DataSetOBJTableAdapters.QueriesTableAdapter())
                Adap.SP_ThemXe
                (
                    Xe.BienSoXe, Xe.SoMay, Xe.SoKhung, Xe.LoaiXe,
                    Xe.MauXe, People.CMNDSoHuu, Xe.NoiDangKy,
                    People.HoTen, People.DiaChi, People.DienThoai, People.NgaySinh
                    
                );
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CheckDaTimThay(string BienSoXe)
        {
            try
            {
                using (DataSetOBJTableAdapters.QueriesTableAdapter Adap = new DataSetOBJTableAdapters.QueriesTableAdapter())
                Adap.SP_CheckDaTimThay(BienSoXe);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int LogIn(string ID,string Pass)
        {
            try
            {
                using (DataSetOBJTableAdapters.SP_LogginTableAdapter Adap = new DataSetOBJTableAdapters.SP_LogginTableAdapter { Connection = new System.Data.SqlClient.SqlConnection(ConnectString) })
                {
                    Adap.Fill(DataSet.SP_Loggin, ID,Pass);
                    return DataSet.SP_Loggin.Rows.Count;
                }
            }
            catch
            {
                return 0;
            }
        }
        public static bool TaoTaiKhoan(string ID, string Pass)
        {
            try
            {
                using (DataSetOBJTableAdapters.QueriesTableAdapter Adap = new DataSetOBJTableAdapters.QueriesTableAdapter())
                    Adap.SP_TaoTaiKhoan(ID,Pass);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

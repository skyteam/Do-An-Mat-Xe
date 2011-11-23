using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FormHost
{
    [ServiceContract]
    
    public interface IBService
    {
        [OperationContract]
        string LogIn();
        [OperationContract]
        string GetBangXeXML();
        [OperationContract]
        bool ThemXe
        (
            string BienSoXe, string SoMay, string SoKhung, string LoaiXe,
            string MauXe, string CMNDSoHuu, DateTime NgayDangKy, string NoiDangKy,
	        string HoTen, string DiaChi, string DienThoai, DateTime NgaySinh
        );
    }
}

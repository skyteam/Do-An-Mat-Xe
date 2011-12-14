using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FormHost
{
    [DataContract]
    public class XeMat
    {
        [DataMember]
        public string BienSoXe;
        [DataMember]
        public string SoMay;
        [DataMember]
        public string SoKhung;
        [DataMember]
        public string LoaiXe;
        [DataMember]
        public string MauXe;
        [DataMember]
        public string CMNDSoHuu;
        [DataMember]
        public string NoiDangKy;
        [DataMember]
        public bool DaTimThay;
    }

    [DataContract]
    public class ChuXe
    {
        [DataMember]
        public string CMNDSoHuu;
        [DataMember]
        public string HoTen;
        [DataMember]
        public string DiaChi;
        [DataMember]
        public string DienThoai;
        [DataMember]
        public DateTime NgaySinh;
    }
    [ServiceContract]
    public interface IBService
    {
        [OperationContract]
        bool ThemXe(XeMat Xe, ChuXe People);
        [OperationContract]
        List<XeMat> TimXeTheoCMND(string CMND);
    }

    

}

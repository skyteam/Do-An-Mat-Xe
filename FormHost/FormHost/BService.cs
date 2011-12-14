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
        public bool ThemXe(XeMat Xe, ChuXe People)
        {
            return Data.WebServiceData.ThemXe(Xe, People);
        }
        public List<XeMat> TimXeTheoCMND(string CMND)
        {
            return Data.WebServiceData.TimXeTheoCMND_List(CMND);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;

namespace FormClient.Control
{
    class ClientControl
    {
        public static MyService.BServiceClient MainProxy;
        public static bool TestBSHTTP(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/BSHTTP");
                BasicHttpBinding binding = new BasicHttpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                MainProxy = new MyService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }
        public static bool TestWSHTTP(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/WSHTTP");
                WSHttpBinding binding = new WSHttpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }
        public static bool TestTCPNET()
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:9000/TCPNET");
                NetTcpBinding binding = new NetTcpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }
        public static void CallBackFunction(Object sender, MyService.LogInCompletedEventArgs e)
        {
            // Nothing to do
        }
        public static bool TestAsynchronous(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/WSHTTP");
                BasicHttpBinding binding = new BasicHttpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }
        private static System.Data.DataTable ConvertXML2Table(string XMLSource)
        {
            System.Windows.Forms.MessageBox.Show(XMLSource);
            System.Data.DataSet TempDataSet = new System.Data.DataSet();
            TempDataSet.ReadXml(new System.IO.StringReader(XMLSource));
            return TempDataSet.Tables[0];
        }
        public static System.Data.DataTable GetBangXe()
        {
            return ConvertXML2Table(MainProxy.GetBangXeXML());
        }
    }
}

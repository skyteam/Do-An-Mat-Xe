using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;
using FormHost.Data;
using FormHost.Control;
using FormHost.Interface;

namespace FormHost.Control
{
    class WebServiceControl
    {
        private static string      BaseAddress;
        private static Type        ContractType = typeof(IBService);
        private static Type        InstanceType = typeof(BService);
        private static ServiceHost Host;
      
        public static void StopService()
        {
            try
            {
                Host.Close();
                Host = null;
            }
            catch
            { }
        }
        public static bool OpenHost()
        {
            try
            {
                Host.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool CreateMEXEndpoint()
        {
            try
            {
                string Address = BaseAddress + "/MEX";
                Host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), Address);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool CreateBSHTTPEndpoint()
        {
            try
            {
                string Address = BaseAddress + "/BSHTTP";
                Host.AddServiceEndpoint(ContractType, new BasicHttpBinding(), Address);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool CreateWSHTTPEndpoint()
        {
            try
            {
                string Address = BaseAddress + "/WSHTTP";
                Host.AddServiceEndpoint(ContractType,  new WSHttpBinding(), Address);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool CreateTCPNETEndpoint()
        {
            try
            {
                const string Address = "net.tcp://localhost/TCPNET";
                NetTcpBinding binding = new NetTcpBinding();
                Host.AddServiceEndpoint(ContractType, binding, Address);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static void InitHost()
        {
            try
            {
                Host = new ServiceHost(InstanceType);
            }
            catch { }
        }
        public static bool StartHTTPService(string BAddress)
        {
            BaseAddress = BAddress;
            //try
            //{
                ServiceMetadataBehavior Behavior = new ServiceMetadataBehavior();
                Behavior.HttpGetEnabled = true;
                Behavior.HttpGetUrl = new Uri(BaseAddress);
                Host.Description.Behaviors.Add(Behavior);
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }
    }
}

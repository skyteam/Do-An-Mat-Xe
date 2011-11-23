using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;

namespace FormHost.Control
{
    class WebServiceControl
    {
        private static FormHost ObjectForm;
        private static string      BaseAddress;
        private static ServiceHost Host;
        private static Type        ContractType = typeof(IBService);
        private static Type        InstanceType = typeof(BService);
        public static void SetObjectForm(FormHost SourceForm)
        {
            ObjectForm = SourceForm;
        }
        public static void UpdateObjectForm()
        {
            ObjectForm.UpdateInfo();
        }
        public static void StopService()
        {
            Host.Close();
            Host = null;
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
                Host.AddServiceEndpoint(ContractType, new WSHttpBinding(), Address);
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
                string Address = "net.tcp://localhost:9000/TCPNET";
                Host.AddServiceEndpoint(ContractType, new NetTcpBinding(), Address);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool StartService(string BAddress)
        {
            BaseAddress = BAddress;
            try
            {
                Host = new ServiceHost(InstanceType);

                ServiceMetadataBehavior Behavior = new ServiceMetadataBehavior();
                Behavior.HttpGetEnabled = true;
                Behavior.HttpGetUrl = new Uri(BaseAddress);
                Host.Description.Behaviors.Add(Behavior);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

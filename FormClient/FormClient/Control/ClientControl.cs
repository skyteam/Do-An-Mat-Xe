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
        public static XService.BServiceClient MainProxy;
        public static void Disconnect()
        {
            try
            {
                MainProxy.Close();
                MainProxy = null;
            }
            catch { }
        }
        public static bool TestBSHTTP(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/BSHTTP");
                BasicHttpBinding binding = new BasicHttpBinding();
                MainProxy = new XService.BServiceClient(binding, address);
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
                MainProxy = new XService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }
        public static bool TestTCPNET()
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost/TCPNET");
                NetTcpBinding binding = new NetTcpBinding();
                MainProxy = new XService.BServiceClient(binding, address);
                return true;
            }
            catch { return false; }
        }

        //public static void CallBackFunction(Object sender, Service.TESTASYCCompletedEventArgs e)
        //{
        //    // Do Nothing
        //}
        //public static bool TestAsynchronous(string BaseAddress)
        //{
        //    try
        //    {
        //        EndpointAddress address = new EndpointAddress(BaseAddress + "/BSHTTP");
        //        BasicHttpBinding binding = new BasicHttpBinding();
        //        MainProxy = new Service.BServiceClient(binding, address);
        //        MainProxy.TESTASYCCompleted += new EventHandler<Service.TESTASYCCompletedEventArgs>(CallBackFunction);
        //        MainProxy.TESTASYCAsync();
        //        return true;
        //    }
        //    catch { return false; }
        //}
    }
}

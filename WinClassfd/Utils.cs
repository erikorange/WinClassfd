using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WinClassfd
{
    public static class Utils
    {
        public static string GetLocalIPv4()
        {
            NetworkInterfaceType _type = NetworkInterfaceType.Wireless80211;
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties adapterProperties = item.GetIPProperties();

                    if (adapterProperties.GatewayAddresses.FirstOrDefault() != null)
                    {
                        foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                output = ip.Address.ToString();
                            }
                        }
                    }
                }
            }
            return output;
        }
    }
}

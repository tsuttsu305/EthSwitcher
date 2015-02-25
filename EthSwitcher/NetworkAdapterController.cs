using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace EthSwitcher {
    public class NetworkAdapterController {
        private ManagementClass _managementClass;
        private ManagementObjectCollection _nics;

        public NetworkAdapterController() {
            init();
        }

        public void init() {
            _managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            _nics = _managementClass.GetInstances();
        }

        public List<String> GetAdapters() {
            init();
            List<String> list = new List<string>();
            foreach (ManagementBaseObject nic in _nics) {
                list.Add((string) nic["Caption"]);
            }
            return list;
        }

        public List<String> GetConnectedAdapters() {
            init();
            List<String> list = new List<string>();
            foreach (ManagementBaseObject nic in _nics) {
                if ((bool) nic["IPEnabled"]) {
                    list.Add((string) nic["Caption"]);
                }
            }
            return list;
        }

        public String GetIPAddress(String adapter) {
            init();
            String ip = "NoIPAddress";

            var nic = GetNetorkAdapter(adapter);

                    if (nic != null && (bool) nic["IPEnabled"]) {
                        if ((bool) nic["DHCPEnabled"]) {
                            if (nic["IPAddress"] != null) {
                                ip = "DHCP:" + ((String[]) nic["IPAddress"])[0];
                            } else {
                                ip = "DHCP";
                            }
                        } else if (nic["IPAddress"] != null) {
                            ip = ((String[]) nic["IPAddress"])[0];
                        }
                    } else {
                        ip = "IP Not Active";
                    }
            return ip;
        }

        public String GetSubnetMask(String adapter) {
            init();

            String mask = "";
            var nic = GetNetorkAdapter(adapter);

            if (nic != null && (bool) nic["IPEnabled"] && nic["IPSubnet"] != null) {
                mask = ((String[]) nic["IPSubnet"])[0];
            }

            return mask;
        }

        public String GetGateway(String adapter) {
            init();

            String gw = "";
            var nic = GetNetorkAdapter(adapter);

            if (nic != null && (bool) nic["IPEnabled"] && nic["DefaultIPGateway"] != null) {
                gw = ((String[]) nic["DefaultIPGateway"])[0];
            }

            return gw;
        }

        public String[] GetDnsServers(String adapter) {
            init();

            String[] dns = {"", ""};
            var nic = GetNetorkAdapter(adapter);

            if (nic != null && (bool) nic["IPEnabled"] && nic["DNSServerSearchOrder"] != null) {
                String[] d = (string[]) nic["DNSServerSearchOrder"];
                dns[0] = d[0];
                if (d.Count() >= 2) {
                    dns[1] = d[1];
                }
            }

            return dns;
        }

        public String GetMacAddress(String adapter) {
            init();
            var nic = GetNetorkAdapter(adapter);
            return nic == null ? "" : (String)nic["MACAddress"];
        }

        /*Adapter Setting*/

        public bool SetIpAddress(String adapter, String ip_address, String subnet_mask) {
            init();

            var nic = GetNetorkAdapter(adapter);
            if (nic == null) return false;

            ManagementBaseObject code;

            if (String.IsNullOrWhiteSpace(ip_address) || String.IsNullOrWhiteSpace(subnet_mask)) {
                code = nic.InvokeMethod("EnableDHCP", null, null);
            } else {
                var newIp = nic.GetMethodParameters("EnableStatic");

                newIp["IPAddress"] = new[] {ip_address};
                newIp["SubnetMask"] = new[] {subnet_mask};

                code = nic.InvokeMethod("EnableStatic", newIp, null);
            }
            return code != null && ((uint)code["ReturnValue"]) != 0;
        }

        public bool SetGateway(String adapter, String gateway) {
            init();

            var nic = GetNetorkAdapter(adapter);
            if (nic == null) return false;

            var newGateway = nic.GetMethodParameters("SetGateways");

            if (String.IsNullOrWhiteSpace(gateway)) {
                newGateway = null;
            } else {
                newGateway["DefaultIPGateway"] = new[] {gateway};
                newGateway["GatewayCostMetric"] = new[] {1};
            }

            var code = nic.InvokeMethod("SetGateways", newGateway, null);
            return code != null && ((uint) code["ReturnValue"]) != 0;
        }

        public bool SetDnsServers(String adapter, String[] dnsservers) {
            init();

            var nic = GetNetorkAdapter(adapter);
            if (nic == null) return false;

            var newDns = nic.GetMethodParameters("SetDNSServerSearchOrder");

            if (String.IsNullOrWhiteSpace(dnsservers[0])) {
                newDns["DNSServerSearchOrder"] = new string[] {};
            } else if (String.IsNullOrWhiteSpace(dnsservers[1])) {
                newDns["DNSServerSearchOrder"] = new[] {dnsservers[0]};
            } else {
                newDns["DNSServerSearchOrder"] = dnsservers;
            }

            var code = nic.InvokeMethod("SetDNSServerSearchOrder", newDns, null);

            return code != null && ((uint) code["ReturnValue"]) == 0;
        }

        public ManagementObject GetNetorkAdapter(String caption) {
            return _nics.Cast<ManagementObject>().FirstOrDefault(o => o["Caption"].Equals(caption));
        }
    }
}
